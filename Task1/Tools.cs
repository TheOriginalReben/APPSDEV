using System;

public class Tools
{
	public Tools()
	{

	}

	public Boolean isValid(string input) {
		int valid = 0, invalid = 0;
		char[] chars = input.ToCharArray();
		for (int i = 0; i < input.Length; i++) {
			if (!isDigit(chars[i]) && !isSpecialCharacter(chars[i])) {
				valid++;
			}else
				invalid++;
		}
		if (invalid > 0)
			return false;
		else
			return true;
	}

	public Boolean isDigit(char input) {
		return input < 0 || input > 0 ? true : false;
	}

    public Boolean isAlphabet(char input) {
		return (input > 'a' && input < 'z') || (input > 'A' && input < 'Z') ? true : false;
	}

    public Boolean isSpecialCharacter(char input) {
		return !isDigit(input) && !isAlphabet(input) ? true : false;
	}
}
