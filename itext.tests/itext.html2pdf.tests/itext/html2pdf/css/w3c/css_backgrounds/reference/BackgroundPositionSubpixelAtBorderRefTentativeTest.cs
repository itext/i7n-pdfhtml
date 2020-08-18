using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds.Reference {
    // TODO DEVSIX-1457 background-position is not supported
    public class BackgroundPositionSubpixelAtBorderRefTentativeTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "background-position-subpixel-at-border-ref.tentative.html";
        }
    }
}
