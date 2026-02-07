//-----------------------------------------------------------------------
// <copyright file="FileConvertorController.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf.Controllers;

/// <summary>
/// The FileConvertorController class is an API controller responsible for handling HTTP requests related to file conversion, specifically converting HTML content into PDF format.
/// It defines an endpoint that accepts a POST request with the HTML content and PDF generation options, and it utilizes the PdfConvertor class to perform the conversion and return the generated PDF as a base64-encoded string in the response.
/// </summary>
[ApiController]
[Route("api/pdf")]
public class FileConvertorController : ControllerBase
{
    /// <summary>
    /// This endpoint accepts a POST request to convert HTML content into a PDF document. It takes a GeneratePdfFromHtmlRequestDto object as input, which contains the HTML content and PDF generation options. The method then calls the PdfConvertor's BuildConvertedDocumentStream method to perform the conversion and returns a GeneratePdfFromHtmlResponseDto object containing the success status and the generated PDF data as a base64-encoded string.
    /// </summary>
    /// <param name="data">The request DTO containing the HTML content and PDF generation options.</param>
    /// <returns>The response DTO containing the success status and the generated PDF data as a base64-encoded string.</returns>
    [HttpPost("generatefromhtml")]
    public async Task<GeneratePdfFromHtmlResponseDto> ConvertFile([FromBody] GeneratePdfFromHtmlRequestDto data)
    {
        return await PdfConvertor.BuildConvertedDocumentStream(data);
    }
}
