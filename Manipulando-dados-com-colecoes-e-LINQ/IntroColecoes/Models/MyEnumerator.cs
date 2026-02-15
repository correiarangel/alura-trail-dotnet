using System.Collections;

namespace IntroColecoes.Models;

public class MyEnumerator : IEnumerator<string>
{
    private readonly string[] _days = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
    private int _pos = -1;

    public string Current => _days[_pos];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public bool MoveNext()
    {
        _pos++;
        return _pos < _days.Length;
    }

    public void Reset()
    {
        _pos = -1;
    }
}
