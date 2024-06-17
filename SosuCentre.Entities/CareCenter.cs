
namespace SosuCentre.Entities
{
    public class CareCenter
    {
        private int careCenterId;
        private string name;
        private Address address;
        private ICollection<Resident> residents;

        public CareCenter(int careCenterId, string name, Address address, ICollection<Resident> residents)
        {
            CareCenterId = careCenterId;
            Name = name;
            Address = address;
            Residents = residents;
        }

        public CareCenter()
        {
            
        }

        #region Properties

        public int CareCenterId
        {
            get => careCenterId;
            set => careCenterId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        // How the fuck do work!!=!3=!==1!???21!1?1
        public Address Address
        {
            get => address;
            set => address = value;
        }
        //This iCollection<Resident> is going to hold all the residents in the carecenter 
        public ICollection<Resident> Residents
        {
            get => residents;
            set => residents = value;
        }

        #endregion
    }
}