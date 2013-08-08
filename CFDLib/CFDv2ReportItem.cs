// 
// CFDv2ReportItem.cs
// 
// Author:
//   Eddy Zavaleta <eddy@mictlanix.com>
// 
// Copyright (C) 2012-2013 Eddy Zavaleta, Mictlanix, and contributors.
// 
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;

namespace Mictlanix.CFDLib
{
    public class CFDv2ReportItem : ICloneable
    {
        public CFDv2ReportItem()
        {
        }

        // 01. RFC del cliente
		public string Taxpayer { get; set; }

        // 02. Serie
		public string Batch { get; set; }

        // 03. Folio del Comprobante Fiscal
		public int Serial { get; set; }

        // 04. Número de Aprobación
		public int ApprovalYear { get; set; }
		public int ApprovalNumber { get; set; }

        // 05. Fecha y hora de expedición (dd/mm/yyyy hh:mm:ss)
		public DateTime Date { get; set; }

        // 06. Monto de la operación 2 decimales
		public decimal Amount { get; set; }

        // 07. Monto del Impuesto 2 decimales
		public decimal Taxes { get; set; }

        // 08. Estado del comprobante (0.- cancelado  1.- vigente)
		public bool IsActive { get; set; }

        // 09. Efecto de Comprobante (I, E, T)
		public CFDv2ReportItemType Type { get; set; }

        // 10. Pedimento
		public string CustomsMotion { get; set; }

        // 11. Fecha de Pedimento (dd/mm/aaaa)
		public DateTime? CustomsMotionDate { get; set; }

        // 12. Aduana
		public string CustomsAgency { get; set; }

        public bool IsCancelled { get { return !IsActive; } }
        
        public override string ToString ()
		{
			string type = Type == CFDv2ReportItemType.Income ? "I" : 
                          Type == CFDv2ReportItemType.Outcome ? "E" : "T";

			return string.Format ("|{0}|{1}|{2}|{12:0000}{3}|{4:dd/MM/yyyy HH:mm:ss}|{5:0.00}|{6:0.00}|{7}|{8}|{9}|{10:dd/MM/yyyy}|{11}|",
                                 Taxpayer, Batch, Serial, ApprovalNumber, Date,
                                 Amount, Taxes, IsActive ? 1 : 0, type,
                                 CustomsMotion, CustomsMotionDate, CustomsAgency, ApprovalYear);
        }
		
		// ICloneable implementation
		public object Clone() {
			return this.MemberwiseClone();
		}
    }
}
