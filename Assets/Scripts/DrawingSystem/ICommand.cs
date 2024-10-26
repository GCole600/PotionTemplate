namespace DrawingSystem
{
    public abstract class ICommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}