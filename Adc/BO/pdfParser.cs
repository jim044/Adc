﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adc.BO
{
    class pdfParser
    {
        public void pdf()
        {
            Bitmap image = new Bitmap("eurotext.tif");
            Tesseract ocr = new tessnet2.Tesseract();
            ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            ocr.Init(@"c:\temp", "fra", false); // To use correct tessdata
            List<tessnet2.Word> result = ocr.DoOCR(image, Rectangle.Empty);
            foreach (tessnet2.Word word in result)
                Console.WriteLine("{0} : {1}", word.Confidence, word.Text);
        }
    }
}
