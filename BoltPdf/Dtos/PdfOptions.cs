//-----------------------------------------------------------------------
// <copyright file="PdfOptions.cs" company="Keka Inc">
//     Copyright (c) Keka.com. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BoltPdf.Dtos;

/// <summary>
/// The class PdfOptions.
/// </summary>
public class PdfOptions
{
    /// <summary>
    /// Gets or sets the Page Size.
    /// available Page Size are A5, A4, A3, Legal, Letter.
    /// </summary>
    public string PageSize { get; set; }

    /// <summary>
    /// Gets or sets the watermark text.
    /// </summary>
    /// <value>
    /// The watermark text.
    /// </value>
    public string WatermarkText { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this [Horizontal].
    /// </summary>
    /// <value>
    /// <c>true</c> if this [Horizontal]; otherwise, <c>false</c>.
    /// </value>
    public bool Horizontal { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this [Is Password Required].
    /// </summary>
    /// <value>
    /// <c>true</c> if this [Is Password Required]; otherwise, <c>false</c>.
    /// </value>
    public bool IsPasswordRequired { get; set; }

    /// <summary>
    /// Gets or sets the    .
    /// </summary>
    /// <value>
    /// The Password.
    /// </value>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the Page Margin.
    /// </summary>
    /// <value>
    /// The Page Margin.
    /// </value>
    public Coordinates PageMargin { get; set; }

    /// <summary>
    /// Gets or sets the Page Border.
    /// </summary>
    /// <value>
    /// The Page Border.
    /// </value>
    public Coordinates PageBorder { get; set; }

    /// <summary>
    /// Gets or sets the Border Line Width.
    /// </summary>
    /// <value>
    /// The Border Line Width.
    /// </value>
    public float BorderLineWidth { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is page number required.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is page number required; otherwise, <c>false</c>.
    /// </value>
    public bool IsPageNumberRequired { get; set; }

    /// <summary>
    /// Gets or sets the page number location.
    /// </summary>
    /// <value>
    /// The page number location.
    /// </value>
    public PageNumberLocation PageNumberLocation { get; set; }

    /// <summary>
    /// Gets or sets the page number align to.
    /// </summary>
    /// <value>
    /// The page number align to.
    /// </value>
    public PageNumberAlignment PageNumberAlignTo { get; set; }

    /// <summary>
    /// Gets or sets the module.
    /// </summary>
    /// <value>
    /// The module.
    /// </value>
    public string Module { get; set; }

    /// <summary>
    /// Gets or sets the type of the file.
    /// </summary>
    /// <value>
    /// The type of the file.
    /// </value>
    public string FileType { get; set; }

    /// <summary>
    /// Gets or sets the name of the file.
    /// </summary>
    /// <value>
    /// The name of the file.
    /// </value>
    public string FileName { get; set; }

    /// <summary>
    /// Gets or sets the callback URL.
    /// </summary>
    /// <value>
    /// The callback URL.
    /// </value>
    public string CallbackUrl { get; set; } = string.Empty;
}

/// <summary>
/// Class represents the Coordinates
/// </summary>
public class Coordinates
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Coordinates" /> class.
    /// </summary>
    /// <param name="top">The Top</param>
    /// <param name="bottom">The Bottom</param>
    /// <param name="left">The Left</param>
    /// <param name="right">The Right.</param>
    public Coordinates(float top, float bottom, float left, float right)
    {
        this.Top = top;
        this.Bottom = bottom;
        this.Left = left;
        this.Right = right;
    }

    /// <summary>
    /// Gets or sets the Top
    /// </summary>
    public float Top { get; set; }

    /// <summary>
    /// Gets or sets the Bottom
    /// </summary>
    public float Bottom { get; set; }

    /// <summary>
    /// Gets or sets the Left
    /// </summary>
    public float Left { get; set; }

    /// <summary>
    /// Gets or sets the Right
    /// </summary>
    public float Right { get; set; }
}

/// <summary>
/// Page Number Location
/// </summary>
public enum PageNumberLocation
{
    Header = 0,
    Footer = 1
}

/// <summary>
/// Page Number Alignment
/// </summary>
public enum PageNumberAlignment
{
    Left = 0,
    Center = 1,
    Right = 2
}