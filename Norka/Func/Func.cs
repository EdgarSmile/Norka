using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Norka.Archiv;
using Norka.Aufträge;
using Norka.Kunden;
using Norka.Lager;
using Norka.Extras;
using Norka.Angebote;
using System.Linq;
using Norka.DB;
using Norka.Rechnungen;
using Exception = System.Exception;
using System.IO;
using Norka.Zeichnen;

namespace Norka.Func
{
  using System.Drawing;
  using System.Text.RegularExpressions;
  using Kalkulationen;
  using Cockpit;
  /// <summary>
  /// Diese Klasse stellt globale Variablen und Methoden zur Verfügung.
  /// </summary>
  public static class Func
  {

    #region Variablen
    /// <summary>
    /// Globale Variable zur Steuerung der "Kunden-Form"
    /// </summary>
    public static Form_Kunde FKunde;

    /// <summary>
    /// Globale Variable zur Steuerung der "KundeMiniAuswahl-Form"
    /// </summary>
    public static Form_Kunde_MiniAuswahl FKundeMiniAuswahl;

    ///<summary>
    /// Globale Variable zur Steuerung der "Kunde_Uebersicht-Form"
    /// </summary>
    public static Form_Kunde_Uebersicht FUebersicht;

    /// <summary>
    /// Globale Variable zur Steuerung der "Kalkulation-Form für das Kalkulationsmodul"
    /// </summary>
    public static Form_Kalkualtion FKalkulation;


    /// <summary>
    /// Globale Variable zur Steuerung der "Angebot-Form für das Angebotmodul"
    /// </summary>
    public static Form_Angebot FAngebot;

    /// <summary>
    /// Globale Variable zur Steuerung der "Kalkulation-Form für das Angebotsmodul"
    /// </summary>
    public static Form_Kalkualtion FAngebotPosition;

    /// <summary>
    /// Globale Variable zur Steuerung der "Angebot-Form für das Auftragsmodul"
    /// </summary>
    public static Form_Auftrag FAuftrag;

    /// <summary>
    /// Globale Variable zur Steuerung der "Kalkulation-Form für das Auftragsmodul"
    /// </summary>
    public static Form_Kalkualtion FAuftragPosition;

    /// <summary>
    /// Globale Variable zur Steuerung der "Start-Form"
    /// </summary>
    public static Form_Start FStart;

    /// <summary>
    /// Globale Variable zur Steuerung der "Optionen-Form"
    /// </summary>
    public static Form_Optionen FOptionen;

    /// <summary>
    /// Globale Variable zur Steuerung der "Archiv-Form"
    /// </summary>
    public static Form_Archiv FArchiv;

    /// <summary>
    /// Globale Variable zur Steuerung der "Rechnung-Form für das Rechnungsmodul"
    /// </summary>
    public static Form_Rechnung FRechnung;

    /// <summary>
    /// Globale Variable zur Steuerung der "Cockpit-Form"
    /// </summary>
    public static Form_Cockpit FCockpit;

    /// <summary>
    /// Globale Variable zur Steuerung der "Zeichnen-Form"
    /// </summary>
    public static Form_Zeichnen FZeichnen;

    /// <summary>
    /// Globale Variable zur Steuerung der "Brief-Form"
    /// </summary>
    public static Form_Brief FBrief;

    /// <summary>
    /// Globale Variable zur Steuerung der "Brief-Form"
    /// </summary>
    public static Form_Lager FLager;


    public static Form_Lager_Ansicht FLagerAnsicht;

    /// <summary>
    /// Globale Variable zur Steuerung der "Kunden-Form"
    /// </summary>
    public static Form_Kunde_Dubletten FKundeDubletten;
    /// <summary>
    /// Default-Farbe für deaktivierte Textboxen.
    /// </summary>
    public static Color CDisabled = Color.FromArgb(224, 224, 224);

    /// <summary>
    /// Default-Farbe für aktivierte Textboxen.
    /// </summary>
    public static Color CEnabled = Color.FromArgb(255, 255, 192);


    #endregion

    #region Methoden


    ///<summary>
    /// Lädt die Summen und Ergebnisse des AuftragsPosition-Grids in die Ergebnissfelder
    ///</summary>
    public static void LoadAuftragSumme()
    {
      decimal tempNettoSumme = 0.00m;
      decimal tempNachlass = 0.00m;
      decimal tempSteuer = 0.00m;
      decimal tempGesamt = 0.00m;


      if (FAuftrag != null)
      {
        foreach (DataGridViewRow row in FAuftrag.dgrPositionen.Rows)
        {
          //decimal i = (decimal)row.Cells["AnlagenStk"].Value;
          tempNettoSumme += (decimal)row.Cells["Einzelpreis"].Value * (decimal)row.Cells["AnlagenStk"].Value;
          tempNettoSumme += (decimal)row.Cells["Alupulver"].Value * (decimal)row.Cells["AnlagenStk"].Value;
        }


        FAuftrag.lblGesPos.Text = String.Format("{0:0,0.00}", tempNettoSumme) + " €";

        //*************************************** Nachlass ***************************************
        if ((FAuftrag.tbxNachlass.Text != "") & FAuftrag.cobNachlass.SelectedIndex == 0) //Prozent
        {
          tempNachlass = tempNettoSumme * decimal.Parse(FAuftrag.tbxNachlass.Text) / 100;
          //TempNachlass = TempNettoSumme;
          FAuftrag.lblNachlass.Text = String.Format("{0:0,0.00}", tempNachlass) + " €";
        }
        else
        {
          tempNachlass = decimal.Parse(FAuftrag.tbxNachlass.Text);
          FAuftrag.lblNachlass.Text = String.Format("{0:0,0.00}", decimal.Parse(FAuftrag.tbxNachlass.Text)) + " €";
        }
        //***************************************************************************************

        //*************************************** Steuer ***************************************
        //if (FAuftrag.cobMwSt.SelectedIndex == 0) // 19 %
        //{
        //    tempSteuer = (tempNettoSumme - tempNachlass) * 0.19m;
        //    FAuftrag.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        //}
        //else //ohne Steuer
        //{
        //    FAuftrag.lblSteuer.Text = String.Format("{0:0,0.00}", 0.00m) + " €";
        //}

        if (tempNettoSumme > 0)
        {
          tempSteuer = (tempNettoSumme - tempNachlass) * (Decimal)FAuftrag.cobMwSt.SelectedValue;
          FAuftrag.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }
        //***************************************************************************************
        FAuftrag.lblZwischensumme.Text = String.Format("{0:0,0.00}", tempNettoSumme - tempNachlass) + " €";

        tempGesamt = tempNettoSumme - tempNachlass + tempSteuer;
        FAuftrag.lblAufGesamt.Text = String.Format("{0:0,0.00}", tempGesamt);

      }





    }

    /// <summary>
    /// Lädt die Summen und Ergebnisse des AngebotsPosition-Grids in die Ergebnissfelder
    /// </summary>
    public static void LoadAngebotSumme()
    {
      decimal tempNettoSumme = 0.00m;
      decimal tempNachlass = 0.00m;
      decimal tempSteuer = 0.00m;
      decimal tempGesamt = 0.00m;


      if (FAngebot != null)
      {
        foreach (DataGridViewRow row in FAngebot.dgrPositionen.Rows)
        {
          if ((int)row.Cells["Eventual"].Value != 1)
          {
            //decimal i = (decimal)row.Cells["AnlagenStk"].Value;
            tempNettoSumme += (decimal)row.Cells["Einzelpreis"].Value * (decimal)row.Cells["AnlagenStk"].Value;
            tempNettoSumme += (decimal)row.Cells["Alupulver"].Value * (decimal)row.Cells["AnlagenStk"].Value;
          }
          
        }

        FAngebot.lblGesPos.Text = String.Format("{0:0,0.00}", tempNettoSumme) + " €";

        //*************************************** Nachlass ***************************************
        if ((FAngebot.tbxNachlass.Text != "") & FAngebot.cobNachlass.SelectedIndex == 0) //Prozent
        {
          tempNachlass = tempNettoSumme * decimal.Parse(FAngebot.tbxNachlass.Text) / 100;
          //TempNachlass = TempNettoSumme;
          FAngebot.lblNachlass.Text = String.Format("{0:0,0.00}", tempNachlass) + " €";
        }
        else
        {
          tempNachlass = decimal.Parse(FAngebot.tbxNachlass.Text);
          FAngebot.lblNachlass.Text = String.Format("{0:0,0.00}", decimal.Parse(FAngebot.tbxNachlass.Text)) + " €";
        }
        //***************************************************************************************

        //*************************************** Steuer ***************************************
        //if (FAngebot.cobMwSt.SelectedIndex == 0) // 19 %
        //{
        //    tempSteuer = (tempNettoSumme - tempNachlass) * 0.19m;
        //    FAngebot.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        //}
        //else //ohne Steuer
        //{
        //    FAngebot.lblSteuer.Text = String.Format("{0:0,0.00}", 0.00m) + " €";
        //}
        if (tempNettoSumme > 0)
        {
          if (FAngebot.cobMwSt.SelectedValue != null)
            tempSteuer = (tempNettoSumme - tempNachlass) * (Decimal)FAngebot.cobMwSt.SelectedValue;
          FAngebot.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }

        //***************************************************************************************

        FAngebot.lblZwischensumme.Text = String.Format("{0:0,0.00}", tempNettoSumme - tempNachlass) + " €";

        tempGesamt = tempNettoSumme - tempNachlass + tempSteuer;
        FAngebot.lblGesamt.Text = String.Format("{0:0,0.00}", tempGesamt);

      }




    }

    /// <summary>
    /// Lädt die Summen und Ergebnisse des RechnungsPosition-Grids in die Ergebnissfelder
    /// </summary>
    public static void LoadRechnungSumme()
    {
      decimal tempNettoSumme = 0.00m;
      decimal tempNachlass = 0.00m;
      decimal tempSteuer = 0.00m;
      decimal tempGesamt = 0.00m;

      if (FRechnung != null)
      {
        foreach (DataGridViewRow row in FRechnung.dgrPositionen.Rows)
        {
          //decimal i = (decimal)row.Cells["AnlagenStk"].Value;
          tempNettoSumme += (decimal)row.Cells["Einzelpreis"].Value * (decimal)row.Cells["AnlagenStk"].Value;
          tempNettoSumme += (decimal)row.Cells["Alupulver"].Value * (decimal)row.Cells["AnlagenStk"].Value;
        }

        FRechnung.lblGesPos.Text = String.Format("{0:0,0.00}", tempNettoSumme) + " €";

        //*************************************** Nachlass ***************************************
        if ((FRechnung.tbxNachlass.Text != "") & FRechnung.cobNachlass.SelectedIndex == 0) //Prozent
        {
          tempNachlass = tempNettoSumme * decimal.Parse(FRechnung.tbxNachlass.Text) / 100;
          //TempNachlass = TempNettoSumme;
          FRechnung.lblNachlass.Text = String.Format("{0:0,0.00}", tempNachlass) + " €";
        }
        else
        {

          tempNachlass = decimal.Parse(FRechnung.tbxNachlass.Text);

          if (Math.Sign(tempNettoSumme) == -1)
          {
            FRechnung.lblNachlass.Text = String.Format("{0:0,0.00}", decimal.Parse(FRechnung.tbxNachlass.Text) * -1) + " €";
          }
          else
          {
            FRechnung.lblNachlass.Text = String.Format("{0:0,0.00}", decimal.Parse(FRechnung.tbxNachlass.Text)) + " €";
          }

        }
        //***************************************************************************************

        //*************************************** Steuer ***************************************
        //Steuer anzeigen bei normaler Rechnung _ Nachlass in Prozent      
        if ((Math.Sign(tempNettoSumme) != -1) & FRechnung.cobNachlass.Text == "Prozent")// & (FRechnung.cobMwSt.SelectedIndex == 0))
        {
          //tempSteuer = (tempNettoSumme - tempNachlass) * 0.19m;
          tempSteuer = (tempNettoSumme - tempNachlass) * (Decimal)FRechnung.cobMwSt.SelectedValue;
          //FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }
        //Steuer anzeigen bei normaler Rechnung _ Nachlass in EURO
        else if ((Math.Sign(tempNettoSumme) != -1) & FRechnung.cobNachlass.Text != "Prozent") // & (FRechnung.cobMwSt.SelectedIndex == 0))
        {
          tempSteuer = (tempNettoSumme - tempNachlass) * (Decimal)FRechnung.cobMwSt.SelectedValue;
          //FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }
        //Steuer anzeigen bei Stornorechnung
        else if ((Math.Sign(tempNettoSumme) == -1) & FRechnung.cobNachlass.Text != "Prozent") //& (FRechnung.cobMwSt.SelectedIndex == 0))
        {
          tempSteuer = (tempNettoSumme + tempNachlass) * (Decimal)FRechnung.cobMwSt.SelectedValue;
          //FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }
        //Steuer anzeigen bei Stornorechnung
        else if ((Math.Sign(tempNettoSumme) == -1) & FRechnung.cobNachlass.Text == "Prozent") // & (FRechnung.cobMwSt.SelectedIndex == 0))
        {
          tempSteuer = (tempNettoSumme + (tempNachlass * -1)) * (Decimal)FRechnung.cobMwSt.SelectedValue;
          //FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        }
        else //ohne Steuer
        {
          //FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", 0.00m) + " €";
          tempSteuer = 0.0m;
        }

        FRechnung.lblSteuer.Text = String.Format("{0:0,0.00}", tempSteuer) + " €";
        //***************************************************************************************




        //Gesamtsumme
        if ((Math.Sign(tempNettoSumme) == -1) & FRechnung.cobNachlass.Text == "Prozent")
        {
          FRechnung.lblZwischensumme.Text = String.Format("{0:0,0.00}", tempNettoSumme - tempNachlass) + " €";

          tempGesamt = tempNettoSumme - tempNachlass + tempSteuer;
          FRechnung.lblAufGesamt.Text = String.Format("{0:0,0.00}", tempGesamt);
        }
        else if ((Math.Sign(tempNettoSumme) == -1) & FRechnung.cobNachlass.Text != "Prozent")
        {
          FRechnung.lblZwischensumme.Text = String.Format("{0:0,0.00}", tempNettoSumme + tempNachlass) + " €";

          tempGesamt = tempNettoSumme + tempNachlass - (tempSteuer * -1);
          FRechnung.lblAufGesamt.Text = String.Format("{0:0,0.00}", tempGesamt);

        }
        else
        {
          FRechnung.lblZwischensumme.Text = String.Format("{0:0,0.00}", tempNettoSumme - tempNachlass) + " €";

          tempGesamt = tempNettoSumme - tempNachlass + tempSteuer;
          FRechnung.lblAufGesamt.Text = String.Format("{0:0,0.00}", tempGesamt);
        }
      }


      //FAngebot.setErgebnisse(TempNettoSumme, TempNachlass, TempSteuer, TempGesamt);
    }

    /// <summary>
    /// Lädt die Positionen zu dem entsprechenden Angebot.
    /// </summary>
    /// <returns>Auflistung aller Positionen zu dem entsprechnden Angebot.</returns>
    public static IQueryable<Angebot_Position> LoadAngebotPositionenUebersicht()
    {
      var dbContext = new DataBaseDataContext();

      var angebotPositionen = dbContext.Angebot_Position.Where(ap => ap.Angebot.AngebotID.Equals(int.Parse(FAngebot.tbxAngNummer.Text)));

      return angebotPositionen;
    }

    /// <summary>
    /// Lädt die Positionen zu dem entsprechenden Angebot.
    /// </summary>
    /// <returns>Auflistung aller Positionen zu dem entsprechnden Auftrag.</returns>
    public static IQueryable<Auftrag_Position> LoadAuftragPositionenUebersicht()
    {
      DataBaseDataContext dbContext = new DataBaseDataContext();

      var auftragPositionen = dbContext.Auftrag_Position.Where(ap => ap.Auftrag.AuftragID.Equals(int.Parse(FAuftrag.tbxAufNummer.Text)));

      return auftragPositionen;
    }
    /// <summary>
    /// Lädt die Positionen zu der entsprechenden Rechnung.
    /// </summary>
    /// <returns>Auflistung aller Positionen zu der entsprechnden Rechnung.</returns>
    public static IQueryable<Rechnung_Position> LoadRechnungPositionenUebersicht()
    {
      DataBaseDataContext dbContext = new DataBaseDataContext();

      var rechnungPositionen = dbContext.Rechnung_Position.Where(r => r.Rechnung.RechnungID.Equals(int.Parse(FRechnung.tbxRechNummer.Text)));

      return rechnungPositionen;
    }

    /// <summary>
    /// Determines whether the specified pEmail is email.
    /// </summary>
    /// <param name="pEmail">The p_email.</param>
    /// <returns>
    /// 	<c>true</c> if the specified pEmail is email; otherwise, <c>false</c>.
    /// </returns>
    // Code-Quelle: http://www.dreamincode.net/code/snippet1374.htm
    public static bool IsEmail(string pEmail)
    {
      //regular expression pattern for valid email
      //addresses, allows for the following domains:
      //com,edu,info,gov,int,mil,net,org,biz,name,museum,coop,aero,pro,tv
      string pattern =
          @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
    (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
      //Regular expression object
      Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
      //boolean variable to return to calling method
      bool valid = false;

      //make sure an email address was provided
      if (string.IsNullOrEmpty(pEmail))
      {
        valid = false;
      }
      else
      {
        //use IsMatch to validate the address
        valid = check.IsMatch(pEmail);
      }
      //return the value to the calling method
      return valid;
    }

    /// <summary>
    /// Determines whether the specified expression is numeric.
    /// </summary>
    /// <param name="pExpression">The expression.</param>
    /// <param name="pOnlyPositive">Flag, ob zu prüfender Wert nur positiv sein darf.</param>
    /// <returns>
    /// 	<c>true</c> if the specified expression is numeric; otherwise, <c>false</c>.
    /// </returns>
    //Code-Quelle: http://support.microsoft.com/kb/329488/de
    public static bool IsNumeric(object pExpression, bool pOnlyPositive)
    {
      // Variable to collect the Return value of the TryParse method.
      bool isNum;

      // Define variable to collect out parameter of the TryParse method. If the conversion fails, the out parameter is zero.
      double retNum;

      // The TryParse method converts a string in a specified style and culture-specific format to its double-precision floating point number equivalent.
      // The TryParse method does not generate an exception if the conversion fails. If the conversion passes, True is returned. If it does not, False is returned.
      isNum = Double.TryParse(Convert.ToString(pExpression), System.Globalization.NumberStyles.Any,
                              System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);


      if (isNum)
      {
        if (pOnlyPositive)
        {
          Double value = Double.Parse(Convert.ToString(pExpression));

          if (Math.Sign(value) == -1)
          {
            isNum = false;
          }
        }
      }
      return isNum;
    }

    /// <summary>
    /// Verschickt die Datei des übergebenen Pfades an die übergebene E-Mail Adresse.
    /// </summary>
    /// <param name="pEmpfänger">Die Empfänger-Email-Adresse</param>
    /// <param name="pBetreff">Der Betrefftext</param>
    /// <param name="pMailText">Der Nachrichtentext</param>
    /// <param name="pDateipfadAnhang">Dateipfad zum Dateianhang</param>
    /// <returns></returns>
    public static void SendDocumentViaEmail(string pEmpfänger, string pBetreff, string pMailText, string pDateipfadAnhang)
    {
      try
      {
        // Initialisiert die Outlook-Applikation.
        var app = new Microsoft.Office.Interop.Outlook.Application();

        // Erzeugt eine neues Mail-Objekt.
        var mail = (MailItem)app.CreateItem(OlItemType.olMailItem);

        // Fügt dem Mail-Objekt einen Empfänger hinzu.
        mail.To = pEmpfänger;

        // Fügt dem Mail-Objekt einen Betreff hinzu.
        mail.Subject = pBetreff;

        // Fügt dem Mail-Objekt eine Textnachricht hinzu.
        mail.Body = pMailText;

        // Fügt dem Mail-Objekt einen Dateianhang hinzu.
        mail.Attachments.Add(pDateipfadAnhang, Missing.Value, Missing.Value, Missing.Value);

        mail.BodyFormat = OlBodyFormat.olFormatHTML;

        //Zeigt das Mail-Fenster in Outlook an.
        mail.Display(true);  //modal


        // Verschicken der Mail.
        //mail.Send();

        // Löscht den temporär angelegten Dateianhang.
        File.Delete(pDateipfadAnhang);


        //MessageBox.Show(String.Format("Email erfolgreich versendet an:\n{0}", pEmpfänger), "Bestätigung", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Freigeben der COM-Objekte
        Marshal.ReleaseComObject(app);
        Marshal.ReleaseComObject(mail);
      }
      catch (Exception e)
      {
        //MessageBox.Show(e.ToString());
        MessageBox.Show("E-Mail konnte nicht versendet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }



    /// <summary>
    /// Legt einen Outlook-Kontakt mit den Daten des übegebenen Kundenobjektes an.
    /// </summary>
    /// <param name="customer">Das Kundenobjekt, für das ein Kontakt in Outlook angelegt werden soll.</param>
    public static void AddOutlookContact(Kunde customer)
    {
      var app = new Microsoft.Office.Interop.Outlook.Application();

      MAPIFolder contactsTargetFolder = GetCustomContactsFolder("NORKA", true);

      try
      {
        if (contactsTargetFolder != null)
        {
          var contact = (ContactItem)contactsTargetFolder.Items.Add(OlItemType.olContactItem);
          contact.Title = customer.Anrede;
          contact.FirstName = customer.Vorname;
          contact.LastName = customer.Name_Firma;
          contact.Email1Address = customer.Email2;
          contact.Email2Address = customer.Email1;
          contact.BusinessTelephoneNumber = customer.Telefon2;
          contact.BusinessFaxNumber = customer.Fax2;
          contact.HomeFaxNumber = customer.Fax1;
          contact.HomeTelephoneNumber = customer.Telefon1;
          contact.MailingAddressStreet = customer.Straße;
          contact.MailingAddressCity = customer.Ort;
          contact.MailingAddressCountry = customer.Land;
          contact.MailingAddressPostalCode = customer.PLZ;
          contact.Body = customer.Notiz;
          contact.WebPage = customer.Homepage;
          contact.MobileTelephoneNumber = customer.Mobil;
          contact.CustomerID = customer.KundeID.ToString();
          contact.Save();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {
        // Freigeben der COM-Objekte
        Marshal.ReleaseComObject(app);
      }


    }

    /// <summary>
    /// Liefert einen Kontakordner zurück.
    /// </summary>
    /// <param name="targetFolderName">Der Name des Kontaktordners</param>
    /// <param name="createIfNotPresent">Flag, ob der Kontaktordner erstellt werden soll, wenn er nicht gefunden werden kann.</param>
    /// <returns>MAPIFolder-Objekt des gefunden/erstellen Kontaktordners</returns>
    private static MAPIFolder GetCustomContactsFolder(string targetFolderName, bool createIfNotPresent)
    {
      var app = new Microsoft.Office.Interop.Outlook.Application();
      MAPIFolder defaultContactsFolder = app.Session.GetDefaultFolder(OlDefaultFolders.olFolderContacts);
      MAPIFolder targetFolder = null;

      foreach (MAPIFolder folder in defaultContactsFolder.Folders)
      {
        if (folder.Name == targetFolderName)
        {
          targetFolder = folder;
          break;
        }
      }

      if (targetFolder == null && createIfNotPresent)
      {
        targetFolder = defaultContactsFolder.Folders.Add(targetFolderName, OlDefaultFolders.olFolderContacts);
      }

      return targetFolder;
    }

    /// <summary>
    /// Ermittelt die Anzahl der Zeilen im übergebenen DataGrid.
    /// </summary>
    /// <returns></returns>
    public static int GetDataGridViewRowCount(DataGridView dataGridView)
    {
      int rows = 0;

      foreach (DataGridViewRow r in dataGridView.Rows)
      {
        rows++;
      }
      return rows;
    }

    /// <summary>
    /// Ermittelt die Anzahl der markierten Zeilen im übergebenen DataGrid.
    /// </summary>
    /// <returns></returns>
    public static int GetDataGridViewMarkedRows(DataGridView dataGridView)
    {
      int rows = 0;

      foreach (DataGridViewRow r in dataGridView.Rows)
      {
        var cell = r.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          if (cell.Value != null)
          {
            rows++;
          }
        }
      }
      return rows;
    }

    #endregion

  }
}