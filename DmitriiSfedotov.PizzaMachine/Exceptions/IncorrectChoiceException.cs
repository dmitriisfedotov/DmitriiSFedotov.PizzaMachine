using System;

namespace DmitriiSFedotov.PizzaMachine.Exceptions;

internal class IncorrectChoiceException(string message) : Exception(message);