//-----------------------------------------------------------------------
// <copyright file="GeneratePdfFromHtmlRequestDto.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf.Dtos;

/// <summary>
/// The class GeneratePdfFromHtmlRequestDto.
/// </summary>
public class GeneratePdfFromHtmlResponseDto
{
    /// <summary>
    /// Gets or sets the field to identify if the request is successful or not.
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// The base 64 content of the generated PDF file.
    /// </summary>
    public string Data { get; set; }
}