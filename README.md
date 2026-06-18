# SortingAnalysis

A small C#/.NET project for implementing, testing, and comparing classic sorting algorithms across different input data patterns.

## Overview

`Sorting Analysis` contains a collection of generic sorting algorithm implementations and supporting infrastructure for running them against generated datasets.

The project is organized around a strategy-based design: each sorting algorithm implements a shared interface and can be registered, tested, and benchmarked in the same way. This makes it easy to compare algorithm behavior across different data distributions such as random, sorted, nearly sorted, and reverse-sorted input.

## Features

- Multiple classic sorting algorithm implementations
- Generic sorting strategy interface
- Data generators for different input patterns
- Lightweight benchmark runner and benchmark suite
- xUnit tests covering common correctness cases
- .NET 8 console project structure

## Technical Highlights

- **Strategy pattern for algorithms**  
  Sorting algorithms are exposed through a shared `ISortingStrategy<T>` interface, making them interchangeable in tests and benchmarks.

- **Generic algorithm implementations**  
  Sorting strategies are implemented generically where applicable, using comparable types instead of being limited to a single primitive type.

- **Separation between sorting, data generation, and benchmarking**  
  The project separates algorithm implementations from input generation and measurement logic.

- **Benchmarking layer**  
  `BenchmarkRunner<T>` and `BenchmarkSuite<T>` provide a small framework for running algorithms against generated datasets and collecting elapsed time results.

- **Automated tests**  
  The test project uses xUnit and verifies sorting behavior for random arrays, sorted arrays, empty arrays, single-element arrays, and arrays with duplicate values.

  ## Notes

- This project is intended as a programming showcase and learning-oriented implementation of data generation, sorting algorithms, and lightweight benchmarking. It is not intended for a statistically rigorous performance benchmark.

  ## License

  This project is licensed under the PolyForm Noncommercial License 1.0.0.
