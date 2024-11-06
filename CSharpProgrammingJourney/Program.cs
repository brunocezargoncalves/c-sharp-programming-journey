using System;
using System.Collections.Generic;
using CSharpProgrammingJourney.ClassesAndMethods;
using CSharpProgrammingJourney.ControlStructures;
using CSharpProgrammingJourney.Fundamentals;

namespace CSharpProgrammingJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            var center = new ExerciseCenter(new Dictionary<string, Action>() {

                // Fundamentos
                {"Fundamentos - Olá Mundo!", HelloWord.Execute},
                {"Fundamentos - Comentários", Comments.Execute},
                {"Fundamentos - Variáveis e Constantes", VariablesAndConstants.Execute},
                {"Fundamentos - Inferência", Inference.Execute},
                {"Fundamentos - Interpolação de String", StringInterpolation.Execute},
                {"Fundamentos - Notação Ponto", DotNotation.Execute},
                {"Fundamentos - Lendo Dados", ReadingData.Execute},
                {"Fundamentos - Formatando Números", FormattingNumbers.Execute},
                {"Fundamentos - Conversões", Conversions.Execute},
                {"Fundamentos - Operadores Aritméticos", ArithmeticOperators.Execute},
                {"Fundamentos - Operadores Relacionais", RelationalOperators.Execute},
                {"Fundamentos - Operadores Lógicos", LogicalOperators.Execute},
                {"Fundamentos - Operadores de Atribuição", AssignmentOperators.Execute},
                {"Fundamentos - Operadores Unários", UnaryOperators.Execute},
                {"Fundamentos - Operador Ternário", TernaryOperator.Execute},
                {"Fundamentos - Testes", Test.Execute},

                // Estruturas de controle
                {"Estruturas de Controle - If", StructureIf.Execute},
                {"Estruturas de Controle - If/Else", StructureIfElse.Execute},
                {"Estruturas de Controle - If/Else/If", StructureIfElseIf.Execute},
                {"Estruturas de Controle - Switch", StructureSwitch.Execute},
                {"Estruturas de Controle - While", StructureWhile.Execute},
                {"Estruturas de Controle - Do/While", StructureDoWhile.Execute},
                {"Estruturas de Controle - For", StructureFor.Execute},
                {"Estruturas de Controle - ForEach", StructureForEach.Execute},
                {"Estruturas de Controle - Break", UsingBreak.Execute},
                {"Estruturas de Controle - Continue", UsingContinue.Execute},

                // Classes e Métodos
                {"Classes, Atibutos e Métodos - Membros", Members.Execute},
                {"Classes, Atibutos e Métodos - Construtores", Constructor.Execute},
                {"Classes, Atibutos e Métodos - Métodos com retorno", MethodsWithReturn.Execute},
                {"Classes, Atibutos e Métodos - Métodos estáticos", StaticMethods.Execute},
                {"Classes, Atibutos e Métodos - Atributos estáticos", StaticAttributes.Execute},
                {"Classes, Atibutos e Métodos - Desafio Atributos", AttributeChallenge.Execute},
                {"Classes, Atibutos e Métodos - Params", Params.Execute},
                {"Classes, Atibutos e Métodos - Parâmetros nomeados", NamedParameters.Execute},
            });

            center.SelectAndRun();
        }
    }
}