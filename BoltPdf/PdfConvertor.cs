//-----------------------------------------------------------------------
// <copyright file="PdfConvertor.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf;

/// <summary>
/// This static class PdfConvertor is responsible for converting HTML content into PDF format using the PuppeteerSharp library.
/// </summary>
public static class PdfConvertor
{
    /// <summary>
    /// The static browser instance to be used for PDF generation. This instance is shared across all requests to optimize resource usage and improve performance.
    /// </summary>
    private static IBrowser? browser;

    /// <summary>
    /// Thread-safe queue to manage page instances. Pages are created on demand and reused across requests to minimize the overhead of creating new pages for each PDF generation request.
    /// </summary>
    private static readonly ConcurrentQueue<IPage> pages = new();

    /// <summary>
    /// This method initializes the PuppeteerSharp browser instance.
    /// It downloads the necessary browser executable if it is not already present and launches the browser in headless mode with specific launch options to optimize performance and security.
    /// This method should be called once during application startup to ensure that the browser is ready for handling PDF generation requests.
    /// </summary>
    /// <returns>
    /// An asynchronous task that represents the initialization process of the browser. The task completes when the browser is successfully launched and ready for use.
    /// </returns>
    public static async Task InitializeBrowserAsync()
    {
        await new BrowserFetcher(SupportedBrowser.Chrome).DownloadAsync();
        browser = await Puppeteer.LaunchAsync(new LaunchOptions
        {
            Headless = true,
            Args =
                [
                    "--no-sandbox",           // Bypass OS security model
                    "--disable-setuid-sandbox", // Disable the setuid sandbox
                    "--disable-gpu",            // Disable GPU hardware acceleration
                    "--window-size=1920,1080",  // Set window size
                ]
        });
    }

    /// <summary>
    /// This method generates a PDF document from the provided HTML content. It uses the PuppeteerSharp library to create a new page, set the HTML content, and generate the PDF data. 
    /// The generated PDF is returned as a base64-encoded string in the response DTO.
    /// </summary>
    /// <param name="generatePdfFromHtmlRequestDto">The request DTO containing the HTML content to be converted to PDF.</param>
    /// <returns>
    /// An asynchronous task that represents the PDF generation process. 
    /// The task returns a GeneratePdfFromHtmlResponseDto containing the success status and the base64-encoded PDF data if the generation is successful.
    /// </returns>
    /// <exception cref="InvalidOperationException">An exception that is thrown when the browser is not initialized.</exception>
    public async static Task<GeneratePdfFromHtmlResponseDto> BuildConvertedDocumentStream(GeneratePdfFromHtmlRequestDto generatePdfFromHtmlRequestDto)
    {
        if (browser == null)
        {
            throw new InvalidOperationException("Browser is not initialized. Please call InitializeBrowserAsync() before using this method.");
        }

        if (!pages.TryDequeue(out var page))
        {
            page = await browser.NewPageAsync();
            page.SetViewportAsync(PdfConvertorOptions.DefaultViewPortOptions).GetAwaiter().GetResult();
        }

        await page.SetContentAsync(generatePdfFromHtmlRequestDto.HtmlContent);
        var byteContent = await page.PdfDataAsync(PdfConvertorOptions.DefaultPdfOptions);
        pages.Enqueue(page);

        return new GeneratePdfFromHtmlResponseDto
        {
            Success = true,
            Data = Convert.ToBase64String(byteContent)
        };
    }
}
