using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UDP;

public class LicenseCheckListener : ILicensingListener
{
    public void allow(LicensingCode code, string message)
    {
        //LicensingCode enum:     
        //RETRY, LICENSED, NOT_LICENSED, STORE_NOT_SUPPORT     
      //  Show(message);  //some meaningful message
    }
    public void dontAllow(LicensingCode code, string message)
    {
        //LicensingCode enum:
        //RETRY, LICENSED, NOT_LICENSED, STORE_NOT_SUPPORT
      //  Show(message);  //some meaningful message 
    }
    public void applicationError(LicensingErrorCode code, string message)
    {
        //LicensingErrorCode enum:
        //ERROR_INVALID_PACKAGE_NAME, ERROR_NON_MATCHING_UID, ERROR_NOT_MARKET_MANAGED, ERROR_CHECK_IN_PROGRESS, ERROR_INVALID_PUBLIC_KEY, ERROR_MISSING_PERMISSION     
      //  Show(message);  //some meaningful message   
    }
}
