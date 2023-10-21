#pragma checksum "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fff9c964d133f3b5ea59669b64cb7893a2c7167"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ViewBookings), @"mvc.1.0.view", @"/Views/Booking/ViewBookings.cshtml")]
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
#line 1 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fff9c964d133f3b5ea59669b64cb7893a2c7167", @"/Views/Booking/ViewBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633685069679b088cf0348c63f836defdc8b025d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_ViewBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
  
    ViewBag.Title = "Booking History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n");
#nullable restore
#line 11 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
         foreach (var booking in Model)
        {
            var isActive = DateTime.Compare(DateTime.Parse(booking.ShowDate), DateTime.Now) >= 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 card text-center my-3\">\n                <div");
            BeginWriteAttribute("class", " class=\"", 379, "\"", 438, 2);
            WriteAttributeValue("", 387, "card-header", 387, 11, true);
#nullable restore
#line 15 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
WriteAttributeValue(" ", 398, isActive ? "bg-dark text-white" : "", 399, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 16 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
               Write(_movieRepo.GetMovie(booking.Show.MovieId).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <span>(");
#nullable restore
#line 17 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                      Write(booking.Show.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\n                </div>\n                <div class=\"card-body\">\n                    <p class=\"card-title mb-1\"><span class=\"text-muted\">Seat No : </span>");
#nullable restore
#line 20 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                    Write(booking.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text mb-1\"><span class=\"text-muted\">Time : </span>");
#nullable restore
#line 21 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                Write(booking.Show.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"card-text mb-1\"><span class=\"text-muted\">Price : </span>");
#nullable restore
#line 22 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                 Write(booking.Show.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div");
            BeginWriteAttribute("class", " class=\"", 1001, "\"", 1060, 2);
            WriteAttributeValue("", 1009, "card-footer", 1009, 11, true);
#nullable restore
#line 24 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
WriteAttributeValue(" ", 1020, isActive ? "bg-dark text-white" : "", 1021, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 25 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
               Write(DateTime.Parse(booking.ShowDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 28 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMovieRepository _movieRepo { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
