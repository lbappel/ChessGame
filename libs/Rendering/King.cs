namespace libs;

public class King : GameObject {

    public King () : base(){
        this.Type = GameObjectType.King;
        this.CharRepresentation = '♚';
        this.Color = ConsoleColor.DarkGreen;
    }
}