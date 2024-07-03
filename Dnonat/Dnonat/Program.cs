double A = 0;
double B = 0;
double i;
double j;

var z = new double[7040];
var b = new char[1760];

while (true)
{
    Memset(b, ' ', 1760);
    Memset(z, 0.0f, 7040);

    for (j = 0; 6.28 > j; j += 0.07)
    for (i = 0; 6.28 > i; i += 0.02)
    {
        var c = Math.Sin(i);
        var d = Math.Cos(j);
        var e = Math.Sin(A);
        var f = Math.Sin(j);
        var g = Math.Cos(A);
        var h = d + 2;
        var D = 1 / ((c * h * e) + (f * g) + 5);
        var l = Math.Cos(i);
        var m = Math.Cos(B);
        var n = Math.Sin(B);
        var t = (c * h * g) - (f * e);

        var x = (int)(40 + (30 * D * ((l * h * m) - (t * n))));
        var y = (int)(12 + (15 * D * ((l * h * n) + (t * m))));
        var o = x + (80 * y);
        var N = (int)(8 * ((((f * e) - (c * d * g)) * m) - (c * d * e) - (f * g) - (l * d * n)));

        if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
        {
            z[o] = D;
            b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
        }
    }

    Console.Clear();
    Nl(b);
    Console.Write(b);

    A += 0.04;
    B += 0.02;

    await Task.Delay(10);
}


static void Memset<T>(T[]? buffer, T val, int bufferSize)
{
    buffer ??= new T[bufferSize];

    for (var i = 0; i < bufferSize; i++)
        buffer[i] = val;
}

static void Nl(IList<char>? buffer)
{
    for (var i = 80; 1760 > i; i += 80)
        buffer![i] = '\n';
}
