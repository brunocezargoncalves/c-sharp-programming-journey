using System;
using System.Collections.Generic;
using CSharpProgrammingJourney.ClassesAndMethods;
using CSharpProgrammingJourney.Collections;
using CSharpProgrammingJourney.ControlStructures;
using CSharpProgrammingJourney.Exceptions;
using CSharpProgrammingJourney.Fundamentals;
using CSharpProgrammingJourney.MethodsAndFunctions;
using CSharpProgrammingJourney.OO;

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
                {"Classes, Atibutos e Métodos - Getters & Setters", GettersAndSetters.Execute},
                {"Classes, Atibutos e Métodos - Props", Props.Execute},
                {"Classes, Atibutos e Métodos - Readonly", Readonly.Execute},
                {"Classes, Atibutos e Métodos - Enum", ExempleEnum.Execute},
                {"Classes, Atibutos e Métodos - Struct", ExempleStruct.Execute},
                {"Classes, Atibutos e Métodos - Struct vs. Class", StructVsClass.Execute},
                {"Classes, Atibutos e Métodos - Parâmetro com valor padrão", ParameterDefaultValue.Execute},

                // Coleções
                {"Coleções - Array", ExempleArray.Execute},
                {"Coleções - List", ExempleList.Execute},
                {"Coleções - ArrayList", ExempleArrayList.Execute},
                {"Coleções - HashSet", ExempleHashSet.Execute},
                {"Coleções - Queue (fila)", ExempleQueue.Execute},
                {"Coleções - Igualdade de objetos", EqualityOfObjects.Execute},
                {"Coleções - Stack (pilha)", ExempleStack.Execute},
                {"Coleções - Dictionary", ExempleDictionary.Execute},

                // OO
                {"Orientação Objetos - Herança",  Inheritance.Execute},
                {"Orientação Objetos - Construtor This",  ThisConstructor.Execute},
                {"Orientação Objetos - Encapsulamento", CSharpProgrammingJourney.OO.Encapsulation.Execute},
                {"Orientação Objetos - Sem Polimorfismo", NoPolymorphism.Execute},
                {"Orientação Objetos - Com Polimorfismo", WithPolymorphism.Execute},
                {"Orientação Objetos - Abstração", Abstract.Execute},
                {"Orientação Objetos - Interface", Interface.Execute},
                {"Orientação Objetos - Sealed", Sealed.Execute},                

                // Métodos e Funções
                {"Métodos e Funções - Lambda", Lambda.Execute},
                {"Métodos e Funções - Lambda Delegate", LambdaDelegate.Execute},
                {"Métodos e Funções - Usando Delegate", UsingDelegate.Execute},
                {"Métodos e Funções - Delegate com função anônima", DelegatesWithAnonymousFunctions.Execute},
                {"Métodos e Funções - Passando Delegate como parâmetro", PassingDelegateAsParameter.Execute},
                {"Métodos e Funções - Métodos de Extensão", ExtensionMethods.Execute},

                // Exceções
                {"Exceções - Primeiro Exemplo", FirstException.Execute},                
                {"Exceções - Customizada", CustomException.Execute},                
            });

            center.SelectAndRun();
        }
    }
}