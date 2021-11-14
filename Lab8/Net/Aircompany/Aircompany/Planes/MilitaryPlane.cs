using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType PlaneType { get; private set; }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType PlaneType)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.PlaneType = PlaneType;
        }
        public override string ToString()
        {
            return base.ToString().Replace( ")" , $", PlaneType = {PlaneType} )");
        }
        public override bool Equals(object obj)
        {
            MilitaryPlane plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PlaneType == plane.PlaneType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PlaneType.GetHashCode();
            return hashCode;
        }

          
    }
}
