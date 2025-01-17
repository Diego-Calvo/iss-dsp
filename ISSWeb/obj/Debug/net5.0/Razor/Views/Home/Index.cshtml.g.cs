#pragma checksum "C:\Users\dicalvo\source\repos\ISSWebsite\iss-dsp\ISSWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633a108f592e815c2c89e9ea889a879764d71a05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\dicalvo\source\repos\ISSWebsite\iss-dsp\ISSWeb\Views\_ViewImports.cshtml"
using ISSWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dicalvo\source\repos\ISSWebsite\iss-dsp\ISSWeb\Views\_ViewImports.cshtml"
using ISSWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633a108f592e815c2c89e9ea889a879764d71a05", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde0c3ce91a49cd412b2611cb11c30589565e201", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dicalvo\source\repos\ISSWebsite\iss-dsp\ISSWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Space Hack";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Hackathon 2021 - Space Hack</h1>
    <video height=""452"" width=""842"" controls>
    <source src=""https://isswebsite.blob.core.windows.net/isswebsite/Final.mp4"" type=""video/mp4"">
    Your browser does not support the video element. Kindly update it to latest version.
  </video >
</div>

<!DOCTYPE html>
<html>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633a108f592e815c2c89e9ea889a879764d71a053840", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Earth View</title>\r\n    <style>\r\n        body {\r\n            margin: 0;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633a108f592e815c2c89e9ea889a879764d71a054963", async() => {
                WriteLiteral(@"
    <br />
<h1>RF Scan in Space Code</h1>

    <p dir=""auto"">Scan radio frequency emissions in the International Space Station.</p>

    <p dir=""auto"">Inspired by, and tested on, <a href=""https://github.com/Azure/mock-spacestation"">the Azure Mock Space Station</a>.</p>

<h2>Description</h2>
    
    <p dir=""auto"">Radio emissions can be monitored with an RF receiver on mount of the International Space Station (ISS). The goal of the project is to enable better space exploration, and safety mechanisms, to further benefit the ISS’ mission of bringing benefits to people on Earth.</p>
    
    <p dir=""auto"">Emissions raw data can be ingested and processed by a python module which would be exported in a Docker container to run in the onboard HP Spaceboard computer-2. The compute needs to be done onboard the ISS because the required sample rates for these signals is high. If there is special interest in a specific frequency, the on-board computer can filter out the noise and keep logs of such signal. Rad");
                WriteLiteral(@"io sources can be natural or man-made. Logs processed will be time, frequency, power and ISS position.</p>

<h2>Inspiration</h2>

    <p dir=""auto"">Space travel will become more usual in the future. There are multiple applications using radio signals that travel and it would be interesting to see how we can manage that computed data in Azure.</p>

<h2>How It Will Work / How It Will Be Built</h2>


    <p dir=""auto"">Process is as follows:</p>

       <ol dir=""auto"">
    <li>HP Spaceboard computer-2 aboard the ISS will run a Python module containerized in Docker (&lt;1 GB) and read raw signal input from an RF receiver, apply a Fourier transform and output information of frequencies. Docker container should run with minimum human interaction. The program will have previous knowledge of which frequency is of interest, remove the noise, calculate the power and save logs in a Parquet format.</li>
    <li>Data from the ISS will be downloaded to ground station in a small transfer window: 2 Mbit/sec, two ");
                WriteLiteral(@"hours a week.</li>
    <li>Azure Storage can get the log file from ground station using AzCopy. A Logic app can identify when a new file has been uploaded and send an email notification from an Office 365 mailbox to team members and turn-on an IoT light bulb.</li>
    <li>Data Factory can orchestrate and transform data from Parquet to CSV.</li>
    <li>Azure Function picks up the log time and returns the ISS location at the time when the frequency was detected. This information will be written back to the CSV.</li>
    <li>SQL server can create tables using the CSV file.</li>
    <li>Power BI can present reports to internal users and embed reports so they can be used by other apps.</li>
    <li>Azure Web App can publish some reports and have 3D visualizations in a .NET code 5 site.</li>
    <li>Note: we are generating mock data for the RF receiver hardware.</li>
    </ol>

    <br />
    <br />
    <br />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
