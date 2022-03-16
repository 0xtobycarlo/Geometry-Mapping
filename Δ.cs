int i = 0;
int r = 0;
Vector3 p = Vector3.zero;
for (int ring = 0; ring < gridSize; ring++)
{
    for (int edge = 0; edge <= ring * 6; edge++)
    {
        Verts.Add(new Vector3(
             p.x + 0.2f * (float)Math.Cos(ring * 60 * Math.PI / 180f),
             p.y + 0.2f * (float)Math.Sin(ring * 60 * Math.PI / 180f),
            p.z + 0));
        p = Verts[Verts.Count - 1];

        if (i >= 2)
        {
        int shift = ((ring - 1) * 6) + edge;
            if (shift % 2 == 0)
            {
                Tris.Add(i);
                Tris.Add(i - shift );
                Tris.Add(i - 1);
            }

            if (shift % 2 != 0)
            {
                Tris.Add(i);
                Tris.Add(i - shift );
                Tris.Add(i - shift - 1);
            }
            i++;
        }
        r += ring * 6;
}    }