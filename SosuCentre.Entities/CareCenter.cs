using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuCentre.Entities
{
    public class CareCenter
    {


        #region Properties

        public int CareCenterId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        // How the fuck do work!!=!3=!==1!???21!1?1
        public Address Address
        {
            get;
            set;
        }
        //This iCollection<Resident> is going to hold all the residents in the carecenter 
        public ICollection<Resident> Residents
        {
            get;
            set;
        }

        #endregion
    }
}