<?php
namespace CalculatorBundle\Entity;

class Calculator
{

    // TODO add class fields and properties, getters and setters
    private $leftOperand;
    private $rightOperand;
    private $operator;

    public function getLeftOperand()
    {
        return $this->leftOperand;
    }

    public function setLeftOperand($operand)
    {
        $this->leftOperand = $operand;

        return $this;
    }

    public function getRightOperand()
    {
        return $this->rightOperand;
    }

    public function setRightOperand($operand)
    {
        $this->rightOperand = $operand;

        return $this;
    }

    public function getOperator()
    {
        return $this->operator;
    }

    public function setOperator($operator)
    {
        $this->operator = $operator;

        return $this;
    }

}