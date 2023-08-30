<?php

namespace CalculatorBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use CalculatorBundle\Entity\Calculator;
use CalculatorBundle\Form\CalculatorType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class CalculatorController extends Controller
{
    /**
     * @param Request $request
     *
     * @Route("/", name="index")
     *
     * @return \Symfony\Component\HttpFoundation\Response
     *
     */
    public function index(Request $request)
    {
        // TODO add $form and calculation logic;

        $calculator = new Calculator();

        $form = $this->createForm(CalculatorType::class, $calculator);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $leftOperand = $calculator->getLeftOperand();
            $rightOperand = $calculator->getRightOperand();
            $operator = $calculator->getOperator();

            $result = 0;

            switch ($operator) {
                case "+":
                    $result = $leftOperand + $rightOperand;
                    break;
                case "-":
                    $result = $leftOperand - $rightOperand;
                    break;
                case "*":
                    $result = $leftOperand * $rightOperand;
                    break;
                case "/":
                    $result = $leftOperand / $rightOperand;
                    break;
                case "v":
                    $result = 1;
                    for ($i = 0; $i < $rightOperand; $i++)
                    {
                        $result = $result * $leftOperand;
                    }
                    break;
                case "^":
                    $result = $leftOperand ^ $rightOperand;
                    break;
                case "&":
                    $result = $leftOperand & $rightOperand;
                    break;
                case "|":
                    $result = $leftOperand | $rightOperand;
                    break;
                default:
                    break;
            }

            return $this->render('calculator/index.html.twig',
                ['result' => $result, 'calculator' => $calculator, 'form' => $form->createView()]);
        }

        return $this->render('calculator/index.html.twig',
        ['form' => $form->createView()]);
    }
}
