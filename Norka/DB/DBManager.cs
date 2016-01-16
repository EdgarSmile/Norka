using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.DB
{
  /// <summary>
  /// 
  /// </summary>
  public static class DBManager
  {

    #region Full Table

    #endregion

    #region Queries

    #region Customer

    /// <summary>
    /// Gets the customer by ID.
    /// </summary>
    /// <param name="customerID">The customer ID.</param>
    /// <returns></returns>
    public static Kunde GetCustomerByID(int customerID)
    {
      Kunde k = null;

      using (var dbContext = new DataBaseDataContext())
      {
        k = dbContext.Kunde.Where(kunde => kunde.KundeID.Equals(customerID)).FirstOrDefault();
      }

      return k;
    }
    #endregion

    #region Angebot

    /// <summary>
    /// Gets the offer by ID.
    /// </summary>
    /// <param name="offerID">The offer ID.</param>
    /// <returns></returns>
    public static Angebot GetAngebotByID(int pAuftragID)
    {
      Angebot a = null;

      using (var dbContext = new DataBaseDataContext())
      {
        a = dbContext.Angebot.Where(angebot => angebot.AngebotID.Equals(pAuftragID)).FirstOrDefault();
      }

      return a;
    }

    
    public static Zeichenparameter GetZeichenparameter()
    {
      Zeichenparameter zeichenparamter = null;

      using (var dbContext = new DataBaseDataContext())
      {
        zeichenparamter = dbContext.Zeichenparameter.Where(zp => zp.ID.Equals(1)).FirstOrDefault();
      }

      return zeichenparamter;
    }

    /// <summary>
    /// Gets the offer details.
    /// </summary>
    /// <param name="offerID">The offer ID.</param>
    /// <returns></returns>
    public static IQueryable<Angebot_Position> GetAngebotPositionen(int pAngebotID)
    {
      IQueryable<Angebot_Position> ap = null;

      using (var dbContext = new DataBaseDataContext())
      {
        ap = dbContext.Angebot_Position.Where(angebotPos => angebotPos.AngebotID.Equals(pAngebotID));
      }

      return ap;
    }

    #endregion

    #region Auftrag
    #endregion

    #region Rechnung
    #endregion

    #region Kalkulation

    public static Kalkulationsparameter GetKalkulationsparameter()
    {
      Kalkulationsparameter kalkulationsparameter = null;

      using (var dbContext = new DataBaseDataContext())
      {
        kalkulationsparameter = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();
      }

      return kalkulationsparameter;
    }

    #endregion


    #endregion


    #region Inserting, Updating, Deleting Data

    #region Offer


    #endregion



    #region Cusomter


    #endregion


    #endregion
  }
}
