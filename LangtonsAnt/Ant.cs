namespace LangtonsAnt
{
    //Understands where he currently exists
    //Understands how to move 2 different ways
    //Understands how to activate/deactivate points when moving
    //Maybe knows the grid? Determines how to move.
    //Should know when it attempts to go out of bounds
    public class Ant
    {
        public Point CurrentPoint { get; set; }
        public Grid Grid { get; set; }
        public void MoveNext()
        {

        }

        public bool IsNextMoveCapableOnBoard()
        {
            return false;
        }

        public void MoveFromActive()
        {

        }

        public void MoveFromInActive()
        {

        }
    }
}
