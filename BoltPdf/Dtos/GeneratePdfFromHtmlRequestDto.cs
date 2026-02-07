//-----------------------------------------------------------------------
// <copyright file="GeneratePdfFromHtmlRequestDto.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf.Dtos;

/// <summary>
/// The class GeneratePdfFromHtmlRequestDto.
/// </summary>
public class GeneratePdfFromHtmlRequestDto
{
    /// <summary>
    /// Gets or sets the request identifier.
    /// </summary>
    /// <value>
    /// The request identifier.
    /// </value>
    public Guid RequestId { get; set; }

    /// <summary>
    /// Gets or sets the content of the HTML.
    /// </summary>
    /// <value>
    /// The content of the HTML.
    /// </value>
    public string HtmlContent { get; set; }

    /// <summary>
    /// Gets or sets the PDF generation options.
    /// </summary>
    /// <value>
    /// The PDF generation options.
    /// </value>
    public PdfOptions PdfGenerationOptions { get; set; }

    /// <summary>
    /// Creates the new.
    /// </summary>
    /// <param name="HtmlContent">Content of the HTML.</param>
    /// <param name="pdfOptions">The PDF options.</param>
    /// <returns>
    /// The new instance of GeneratePdfFromHtmlRequestDto.
    /// </returns>
    public static GeneratePdfFromHtmlRequestDto CreateNew(string HtmlContent, PdfOptions pdfOptions)
    {
        ArgumentNullException.ThrowIfNull(HtmlContent); 
        
        return new GeneratePdfFromHtmlRequestDto()
        {
            HtmlContent = HtmlContent, 
            PdfGenerationOptions = pdfOptions,
            RequestId = Guid.NewGuid()
        };
    }
}