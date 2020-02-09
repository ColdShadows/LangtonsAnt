namespace LangtonsAnt
{
    //Point in the grid. Understands whether or not it is activated.
    //Should be agnostic of other points
    //shouldn't care whether the ant is in it or not. Ant can manage that.
    //Not sure what else is useful for point yet, whether it needs to care about X/Y
    public class Point
    {
        public bool IsActivated { get; set; }
    }
}
