namespace DesignPatterns.SOLID.LP
{
    public static class MyClient
    {
        public static string UseIt(Rectangle r)
        {
            if (r.IsSquare)
            {
                r.Height = r.Width = 10;
            }
            else
            {
                r.Height = 10;
            }
            
            if (r.IsSquare)
            {
                return $"Expected area of {10 * 10}, got {r.Area}";
            }

            return $"Expected area of {10 * r.Width}, got {r.Area}";
        }
    }
}
