namespace Prototype
{
    enum Size
    {
        Small, Medium, Big
    }

    abstract class TetrisPrototype
    {
        public abstract TetrisPrototype Clone();
    }

    class LinePiece : TetrisPrototype
    {
        public Size Size { get; set; }

        public LinePiece(Size size)
        {
            this.Size = size;
        }

        public override TetrisPrototype Clone()
        {
            return this.MemberwiseClone() as TetrisPrototype;
        }
    }

}
