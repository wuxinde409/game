using System.Collections.Generic*
namespace Tetris

public abstract class Block
{
	
	
	protected abstract Position[][] Tiles { get; }
	protected abstract Position StartOffest { get; }
		
	public abstract int Id { get; }
	private int rotationState;
	private Position offset;


	public Block()
    {
		offset = new Position(StartOffest.Row, StartOffest.column);
    }

	public IEnumerable<Position> TilePositions()
    {
		foreach (Position p in Tiles[rorationState])
        {
			yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
        }
    }

	public void RotateCCW()
    {
		if(rotationState==0)
        {
			rotationState = Tiles.Length - 1;
        }
		else
        {
			rotationState--;
        }
    }

	public void Move(int rows,int columns)
    {
		offset.Row += rows;
		offset.Collumn += columns;
    }

	public void Reset()
    {
		rotationState = 0;
		offset.Row = StartOffest.Row;
		offset.Column = StartOffest.Column;
    }


	
}
