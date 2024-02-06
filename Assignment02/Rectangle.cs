public class Rectangle
{
    private int length;
    private int width;

    // Default constructor
    public Rectangle()
    {
        length = 1;
        width = 1;
    }

    // Non-default constructor
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    // Get Length method
    public int GetLength()
    {
        return length;
    }

    //Set Length method
    public int SetLength(int length)
    {
        if (length > 0)
        {
            this.length = length;
        }
        else
        {
            // If an invalid length is provided, set the length to its default value.
            this.length = 1;
        }
        return this.length;
    }

    //Get width method
    public int GetWidth()
    {
        return width;
    }

    //set width method
    public int SetWidth(int width)
    {
        if (width > 0)
        {
            this.width = width;
        }
        else
        {
            // If an invalid width is provided, set the width to its default value.
            this.width = 1;
        }
        return this.width;
    }

    //Get perimeter method
    public int GetPerimeter()
    {
        return 2 * (length + width);
    }

    // get area method
    public int GetArea()
    {
        return length * width;
    }
}