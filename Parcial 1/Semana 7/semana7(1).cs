using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    // Función que verifica si la expresión está balanceada
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            // Si es un símbolo de apertura, se apila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si es un símbolo de cierre, se verifica
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no está balanceado
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                // Verifica correspondencia entre apertura y cierre
                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                {
                    return false;
                }
            }
        }

        // Si la pila queda vacía, está balanceado
        return pila.Count == 0;
    }

    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
