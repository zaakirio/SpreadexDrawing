# DrawingPackage

A C# console app which simulates a drawing package

## Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022 Community Edition 

## Project Structure

The solution consists of two projects:
- `SpreadexDrawing`: Main library containing widget implementations
- `SpreadexDrawing.Tests`: NUnit test project for testing widget functionality

## Features

The package includes the following widget types:
- Rectangle: Defined by position (x,y), width, and height
- Square: Defined by position (x,y) and size
- Ellipse: Defined by position (x,y), horizontal and vertical diameters
- Circle: Defined by position (x,y) and diameter
- Textbox: Defined by position (x,y), width, height, and text content

All widgets inherit from an abstract `Widget` base class that provides common positioning functionality.

## Testing

The project uses NUnit for testing. Test cases cover:
- Valid object construction
- Invalid parameter validation
- String representation verification
- Edge cases and error conditions

To run tests:
1. Open the solution in Visual Studio
2. Open Test Explorer (View > Test Explorer)
3. Click "Run All Tests" or select specific tests to run


