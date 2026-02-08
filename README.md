# BoltPdf

BoltPdf is a lightweight, container-ready .NET 8 Web API for converting HTML content to PDF documents. It leverages PuppeteerSharp and DinkToPdf for high-fidelity PDF generation, exposing a simple HTTP endpoint for integration into your applications or workflows.

## Features

- **HTML to PDF Conversion**: Accepts raw HTML and returns a base64-encoded PDF.
- **RESTful API**: Exposes a single POST endpoint for PDF generation.
- **Customizable Options**: Supports PDF generation options via request DTO.
- **.NET 8 & C# 12**: Modern, high-performance, and cross-platform.
- **Swagger/OpenAPI**: Integrated API documentation via Swashbuckle.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/) (optional, for containerized deployment)

### Build and Run Locally

1. **Clone the repository:** git clone https://github.com/suyashshukla/BoltPdf.git cd BoltPdf
2. **Restore dependencies and run:** dotnet restore dotnet run --project BoltPdf/BoltPdf.csproj
3. **Access the API:** Swagger UI: [http://localhost:5000/swagger](http://localhost:5000/swagger) (or the port specified in your launch settings)

### Docker

1. **Build the Docker image:** docker build -t boltpdf:latest ./BoltPdf
2. **Run the container:** docker run -d -p 5000:80 boltpdf:latest

## API Usage

### Endpoint

`POST /api/pdf/generatefromhtml`

#### Request Body
{ "requestId": "guid (optional)", "htmlContent": "<html>...</html>", "pdfGenerationOptions": { // PDF options as defined in PdfOptions } }


#### Response
{ "success": true, "data": "base64-encoded-pdf" }

- `success`: Indicates if the PDF was generated successfully.
- `data`: Base64-encoded PDF file content.

## Project Structure

- `Controllers/` – API endpoints
- `Dtos/` – Data transfer objects for requests and responses
- `PdfConvertor.cs` – Core logic for HTML-to-PDF conversion
- `PDfConvertorOptions.cs` – Default options for PDF generation
- `Dockerfile` – Containerization support

## Dependencies

- [PuppeteerSharp](https://github.com/hardkoded/puppeteer-sharp)
- [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf)
- [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

## License

See [LICENSE](LICENSE) for details.

---

**Contributions and issues are welcome!**
