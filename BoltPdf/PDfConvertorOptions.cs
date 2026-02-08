//-----------------------------------------------------------------------
// <copyright file="PDfConvertorOptions.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf;

/// <summary>
/// This class PdfConvertorOptions provides default configuration options for the PDF conversion process using the PuppeteerSharp library.
/// </summary>
public static class PdfConvertorOptions
{
    /// <summary>
    /// This property DefaultViewPortOptions defines the default viewport settings for the browser page used in PDF generation.
    /// </summary>
    public static ViewPortOptions DefaultViewPortOptions = new()
    {
        Width = 1920,
        Height = 1080
    };

    /// <summary>
    /// This property NavigatorOptions defines the default navigation options for the browser page during PDF generation.
    /// It specifies that the navigation should wait until there are no more than 0 network connections for at least 500 ms (networkidle0) and sets a timeout of 60 seconds for the navigation process.
    /// </summary>
    public static NavigationOptions NavigatorOptions = new()
    {
        WaitUntil = [WaitUntilNavigation.Networkidle0],
        Timeout = 60000 // Set a timeout of 60 seconds for navigation
    };

    /// <summary>
    /// This property DefaultPdfOptions defines the default PDF generation options for the PuppeteerSharp library.
    /// </summary>
    public static PuppeteerSharp.PdfOptions DefaultPdfOptions = new()
    {
        Format = PaperFormat.A4,
        PrintBackground = true,
        PreferCSSPageSize = true,
        MarginOptions = new MarginOptions
        {
            Top = "20px",
            Bottom = "20px",
            Left = "20px",
            Right = "20px"
        }
    };
}
