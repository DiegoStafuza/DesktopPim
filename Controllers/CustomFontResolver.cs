using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;

namespace DesktopPim.Controllers
{
    public class CustomFontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            
            if (faceName == "arial")
            {
                
                string fontPath = @"C:\Users\diego\OneDrive\Documentos\PIM\arial.ttf";
                if (File.Exists(fontPath))
                {
                    return File.ReadAllBytes(fontPath);
                }
            }

            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            
            return null;
        }

        public IFontResolver GetFontResolver()
        {
            return this;
        }
    }
}
