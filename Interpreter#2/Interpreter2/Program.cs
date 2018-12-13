using System;
using System.Collections.Generic;

namespace Interpreter
{
 
    /*
     *  Интерпретатор преобразует набор инструкций, написанных с применением определённой нотации, служащей для своих целей, в другой вид. 
        Как правило, набор инструкций ограничен. 
*/
    class MainApp
    {
        static void Main()
        {
            // Client - клиент: строит (или получает в готовом виде) абстрактное синтаксическое дерево, представляющее отдельное предложение на языке с данной грамматикой.

            string roman = "CDXLXXXXV"; //"MMMCMXXVIII"; // MCMLXXXVIII  // MMMCMXCIX
            Context context = new Context(roman);

            
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }

    //Context - контекст: содержит информацию, глобальную по отношению к интерпретатору;
    class Context
    {
        private string input;
        private int output;

        // Constructor
        public Context(string input)
        {
            this.input = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        // Gets or sets output
        public int Output
        {
            get { return output; }
            set { output = value; }
        }
    }

    // AbstractExpression – абстрактный класс, определяющий общий интерфейс для всех производных классов структуры и включающий метод Interpret.
    abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }

    /* TerminalExpression (LiteralExpression) - терминальное выражение:
        - реализует операцию Interpret для терминальных символов грамматики;
        - необходим отдельный экземпляр для каждого терминального символа в предложении;
    */
    class ThousandExpression : Expression
    {
        public override string One() { return "M"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Nine() { return " "; }
        public override int Multiplier() { return 1000; }
    }

    class HundredExpression : Expression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }

    class TenExpression : Expression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    class OneExpression : Expression
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }


    class OneExpressionA : Expression
    {
        public override string One() { return "1"; }
        public override string Four() { return "4"; }
        public override string Five() { return "5"; }
        public override string Nine() { return "9"; }
        public override int Multiplier() { return 1; }
    }
}
