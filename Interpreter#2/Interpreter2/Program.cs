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

            string roman =  "CDLXXXV"; //"MMMCMXXVIII"; // MCMLXXXVIII  // MMMCMXCIX
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



            int arab = 485; //"CDXLXXXXV"; //"MMMCMXXVIII"; // MCMLXXXVIII  // MMMCMXCIX
            ContextA contextA = new ContextA(arab);


            List<ExpressionA> treeA = new List<ExpressionA>();
            treeA.Add(new ThousandExpressionA());
            treeA.Add(new HundredExpressionA());
            treeA.Add(new TenExpressionA());
            treeA.Add(new OneExpressionA());

            // Interpret
            foreach (ExpressionA exp in treeA)
            {
                exp.Interpret(contextA);
            }

            Console.WriteLine("{0} = {1}", arab, contextA.Output);

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

    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////// 
    /// </summary>
    /// 

    class ContextA
    {
        private  int input;
        private string output;

        // Constructor
        public ContextA(int input)
        {
            this.input = input;
        }

        // Gets or sets input
        public int Input
        {
            get { return input; }
            set { input = value; }
        }

        // Gets or sets output
        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }



    abstract class ExpressionA
    {
       protected string symbl;
        public void Interpret(ContextA context)
        {
            if (context.Input <= 0)
                return;

            //   if (context.Input.StartsWith(Nine().ToString()))
            if (context.Input / One() != 0 && context.Input / One() * One() >= Nine())
            {
                context.Output += (Multiplier());
                context.Input = context.Input - Nine();
            }
            else if (context.Input / One() != 0 && context.Input / One() * One() >= Five())
            {
                context.Output += (Multiplier());
                context.Input = context.Input - Five();
            }
            else if (context.Input / One() != 0 && context.Input / One()* One() >= Four())
            {
                context.Output += (Multiplier());
                context.Input = context.Input - Four();
            }
          
            
            while (context.Input >= One() && context.Input / One() * One() >= One())
            {
                context.Output += ( Multiplier());
                context.Input = context.Input - One(); 
            }
        }

        public abstract int One();
        public abstract int Four();
        public abstract int Five();
        public abstract int Nine();
        public abstract string Multiplier();
    }

    class ThousandExpressionA : ExpressionA
    {
        public override int One()
        {
            symbl = "M";
            return 1000;
        }
        public override int Four()
        {
            symbl = "";
            return 0;
        }
        public override int Five()
        {
            symbl = "";
            return 0;
        }
        public override int Nine()
        {
            symbl = "";
            return 0;
        }
        public override string Multiplier() { return symbl; }
    }

    class HundredExpressionA : ExpressionA
    {
        public override int One()
        {
            symbl = "C";
            return 100;
        }
        public override int Four()
        {
            symbl = "CD";
            return 400;
        }
        public override int Five()
        {
            symbl = "D";
            return 500;
        }
        public override int Nine()
        {
            symbl = "CM";
            return 900;
        }
        public override string Multiplier() { return symbl; }
    }

    class TenExpressionA : ExpressionA
    {
        public override int One() {
            symbl = "X";
            return 10;
        }
        public override int Four() {
            symbl = "XL";
            return 40; }
        public override int Five() {
            symbl = "L";
            return 50; }
        public override int Nine() {
            symbl = "XC";
            return 90; }
        public override string Multiplier() { return symbl; }
    }

    class OneExpressionA : ExpressionA
    {
        public override int One() {
            symbl = "I";
            return 1; }
        public override int Four() {
            symbl = "IV";
            return 4; }
        public override int Five() {
            symbl = "V";
            return 5; }
        public override int Nine() {
            symbl = "IX";
            return 9; }
        public override string Multiplier() { return symbl; }
    }
}
