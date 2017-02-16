using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabulani_Punk
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class debitorders
    {

        private debitordersDeduction[] deductionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deduction")]
        public debitordersDeduction[] deduction
        {
            get
            {
                return this.deductionField;
            }
            set
            {
                this.deductionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class debitordersDeduction
    {

        private string accountholderField;

        private ulong accountnumberField;

        private string accounttypeField;

        private string banknameField;

        private string branchField;

        private decimal amountField;

        private string dateField;

        /// <remarks/>
        public string accountholder
        {
            get
            {
                return this.accountholderField;
            }
            set
            {
                this.accountholderField = value;
            }
        }

        /// <remarks/>
        public ulong accountnumber
        {
            get
            {
                return this.accountnumberField;
            }
            set
            {
                this.accountnumberField = value;
            }
        }

        /// <remarks/>
        public string accounttype
        {
            get
            {
                return this.accounttypeField;
            }
            set
            {
                this.accounttypeField = value;
            }
        }

        /// <remarks/>
        public string bankname
        {
            get
            {
                return this.banknameField;
            }
            set
            {
                this.banknameField = value;
            }
        }

        /// <remarks/>
        public string branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }

        /// <remarks/>
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }


}
