# CI Pipeline with Errors

## Introduction

This project is designed to contain errors with the purpose of helping students learn to identify and fix issues using unit tests and integration tests. The project consists of a simple calculator (Calculator) and a math service (MathService), both of which contain deliberate errors that should be caught in the CI pipeline.  

## Purpose

The purpose of this project is to provide students with practical experience in:  
- Writing unit tests and integration tests
- Using mocking frameworks like Moq
- Setting up a CI pipeline to automatically run tests and catch errors

## Project Structure

The project consists of the following files and directories:  
- bad-project/Calculator.cs: Contains the Calculator class with a simple Add method.
- bad-project/MathService.cs: Contains the MathService class, which uses the Calculator to perform calculations.
- bad-project.tests/CalculatorUnitTests.cs: Contains unit tests for the Calculator class.
- bad-project.tests/MathServiceUnitTests.cs: Contains unit tests for the MathService class, both with a fake implementation and with Moq.
- bad-project.tests/MathServiceIntegrationTests.cs: Contains integration tests for the MathService class.

## Errors

The project contains deliberate errors that should be caught by the tests:
- The Calculator.Add method returns incorrect results in certain tests.
- The MathService.CalculateSum method returns incorrect results when using the Calculator.

## CI Pipeline

To ensure all errors are caught, you should set up a CI pipeline that automatically runs all unit tests and integration tests. This can be done using GitHub Actions, Azure Pipelines, or another CI tool of your choice.
