﻿using System.Linq.Expressions;
using Homework11.Services.MathCalculator.MathExpressionGraph;

namespace Homework11.Services.MathCalculator.ParallelCalculator;

public class MathExpressionCalculator : IMathExpressionCalculator
{
    public async Task<double> CalculateAsync(Expression current,
        IReadOnlyDictionary<Expression, MathExpression> dependencies)
    {
        if (!dependencies.ContainsKey(current))
        {
            return double.Parse(current.ToString());
        }
        
        await Task.Delay(1000);
        var left = Task.Run(() => 
            CalculateAsync(dependencies[current].LeftExpression, dependencies));
        var right = Task.Run(() => 
            CalculateAsync(dependencies[current].RightExpression, dependencies));

        var results = await Task.WhenAll(left, right);
        return CalculateExpression(results[0], current.NodeType, results[1]);
    }

    private static double CalculateExpression(double v1, ExpressionType expressionType, double v2)
    {
        double result =  0;
        switch (expressionType)
        {
            case ExpressionType.Add:
                result = v1 + v2;
                break;
            case ExpressionType.Subtract:
                result = v1 - v2;
                break;
            case ExpressionType.Divide:
                result = v2 != 0 
                    ? v1 / v2 
                    : throw new DivideByZeroException("Division by zero");
                break;
            case ExpressionType.Multiply:
                result = v1 * v2;
                break;
        }

        return result;
    }
}