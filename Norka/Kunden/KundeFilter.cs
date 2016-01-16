using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Norka.Kunden
{
    public class KundeFilter
    {
        #region Variables/Constants

        private String _kundeid;

        private String _namefirma;

        private String _matchcode;

        private String _ort;

        private String _plz;

        private CheckState _status;

        private String _kategorie;


        #endregion


        #region Properties

        public Boolean IsDefault{ get; set;}

        public String Name_Firma
        {
            get
            {
                return _namefirma;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _namefirma = string.Format("Kunde.Name_Firma LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public String KundeId
        {
            get
            {
                return _kundeid;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _kundeid = string.Format("Kunde.KundeID LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public CheckState Status
        {
            get
            {
                return _status;
            }
            set
            {

                _status = value;

            }
        }

        public String Matchcode
        {
            get
            {
                return _matchcode;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _matchcode = string.Format("Kunde.Matchcode LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public String Ort
        {
            get
            {
                return _ort;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _ort = string.Format("Kunde.Ort LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public String PLZ
        {
            get
            {
                return _plz;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _plz = string.Format("Kunde.Plz LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public String Kategorie
        {
            get
            {
                return _kategorie;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _kategorie = string.Format("Kunde.Kategorie LIKE \'%{0}%\'  AND ", value);
                }
            }
        }

        public String Query { get; set; }


        #endregion


        #region Methods

        public String GetSqlQuery(KundeFilter k)
        {
            var sb = new StringBuilder();

            String whereclause;

            String sql;

            foreach (var property in k.GetType().GetProperties())
            {
                if (property.Name != "IsDefault" & property.GetValue(k,null) != null)
                {
                    if (property.PropertyType != typeof(CheckState))
                    {
                        sb.Append(property.GetValue(k, null));
                    }
                    else
                    {
                        if ((CheckState)property.GetValue(k, null) != CheckState.Indeterminate)
                        {
                            string statusClause = (CheckState)property.GetValue(k, null) == CheckState.Checked
                                                      ? "Kunde.Status = \'gesperrt\' AND "
                                                      : "Kunde.Status is null AND ";

                            sb.Append(statusClause);
                        }
                    }

                }
            }

            if (sb.Length > 0)
            {
                whereclause = sb.ToString().Substring(0, sb.Length - 4);

                sql = "SELECT KundeID, Anrede, Vorname, Name_Firma, Straße, AdressZusatz1, AdressZusatz2, PLZ, Ort, Land, Telefon2, Fax2, Mobil, Email2, Homepage, Matchcode, Kategorie, Status, Notiz FROM KUNDE WHERE " + whereclause;
            }
            else
            {
              sql = "SELECT KundeID, Anrede, Vorname, Name_Firma, Straße, AdressZusatz1, AdressZusatz2, PLZ, Ort, Land, Telefon2, Fax2, Mobil, Email2, Homepage, Matchcode, Kategorie, Status, Notiz FROM KUNDE";
                IsDefault = true;
            }

            return sql;
        }

        #endregion
    }
}
