using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterSeperator : MonoBehaviour
{

	public string newWord = "";
	public InputField myField;
	public BuildWord builder;
	public List<GameObject> lowerLetters;
	public List<GameObject> upperLetters;

	private void Start()
	{
		builder.itemsList.Clear();
	}

	

	public void CreateWord()
	{
		builder.itemsList.Clear();
		newWord = myField.text;
		
		foreach (char letter in newWord)
		{
			if (char.IsLower(letter))
			{
				switch (letter)
				{
						case 'a':
							builder.itemsList.Add(lowerLetters[0]);
							break;
						case 'b':
							builder.itemsList.Add(lowerLetters[1]);
							break;
						case 'c':
							builder.itemsList.Add(lowerLetters[2]);
							break;
						case 'd':
							builder.itemsList.Add(lowerLetters[3]);
							break;
						case 'e':
							builder.itemsList.Add(lowerLetters[4]);
							break;
						case 'f':
							builder.itemsList.Add(lowerLetters[5]);
							break;
						case 'g':
							builder.itemsList.Add(lowerLetters[6]);
							break;
						case 'h':
							builder.itemsList.Add(lowerLetters[7]);
							break;
						case 'i':
							builder.itemsList.Add(lowerLetters[8]);
							break;
						case 'j':
							builder.itemsList.Add(lowerLetters[9]);
							break;
						case 'k':
							builder.itemsList.Add(lowerLetters[10]);
							break;
						case 'l':
							builder.itemsList.Add(lowerLetters[11]);
							break;
						case 'm':
							builder.itemsList.Add(lowerLetters[12]);
							break;
						case 'n':
							builder.itemsList.Add(lowerLetters[13]);
							break;
						case 'o':
							builder.itemsList.Add(lowerLetters[14]);
							break;
						case 'p':
							builder.itemsList.Add(lowerLetters[15]);
							break;
						case 'q':
							builder.itemsList.Add(lowerLetters[16]);
							break;
						case 'r':
							builder.itemsList.Add(lowerLetters[17]);
							break;
						case 's':
							builder.itemsList.Add(lowerLetters[18]);
							break;
						case 't':
							builder.itemsList.Add(lowerLetters[19]);
							break;
						case 'u':
							builder.itemsList.Add(lowerLetters[20]);
							break;
						case 'v':
							builder.itemsList.Add(lowerLetters[21]);
							break;
						case 'w':
							builder.itemsList.Add(lowerLetters[22]);
							break;
						case 'x':
							builder.itemsList.Add(lowerLetters[23]);
							break;
						case 'y':
							builder.itemsList.Add(lowerLetters[24]);
							break;
						case 'z':
							builder.itemsList.Add(lowerLetters[25]);
							break;
								
				
				}
				
				Debug.Log(letter);
			}
			else
			{
				switch (letter)
				{
						case 'A':
							builder.itemsList.Add(upperLetters[0]);
							break;
						case 'B':
							builder.itemsList.Add(upperLetters[1]);
							break;
						case 'C':
							builder.itemsList.Add(upperLetters[2]);
							break;
						case 'D':
							builder.itemsList.Add(upperLetters[3]);
							break;
						case 'E':
							builder.itemsList.Add(upperLetters[4]);
							break;
						case 'F':
							builder.itemsList.Add(upperLetters[5]);
							break;
						case 'G':
							builder.itemsList.Add(upperLetters[6]);
							break;
						case 'H':
							builder.itemsList.Add(upperLetters[7]);
							break;
						case 'I':
							builder.itemsList.Add(upperLetters[8]);
							break;
						case 'J':
							builder.itemsList.Add(upperLetters[9]);
							break;
						case 'K':
							builder.itemsList.Add(upperLetters[10]);
							break;
						case 'L':
							builder.itemsList.Add(upperLetters[11]);
							break;
						case 'M':
							builder.itemsList.Add(upperLetters[12]);
							break;
						case 'N':
							builder.itemsList.Add(upperLetters[13]);
							break;
						case 'O':
							builder.itemsList.Add(upperLetters[14]);
							break;
						case 'P':
							builder.itemsList.Add(upperLetters[15]);
							break;
						case 'Q':
							builder.itemsList.Add(upperLetters[16]);
							break;
						case 'R':
							builder.itemsList.Add(upperLetters[17]);
							break;
						case 'S':
							builder.itemsList.Add(upperLetters[18]);
							break;
						case 'T':
							builder.itemsList.Add(upperLetters[19]);
							break;
						case 'U':
							builder.itemsList.Add(upperLetters[20]);
							break;
						case 'V':
							builder.itemsList.Add(upperLetters[21]);
							break;
						case 'W':
							builder.itemsList.Add(upperLetters[22]);
							break;
						case 'X':
							builder.itemsList.Add(upperLetters[23]);
							break;
						case 'Y':
							builder.itemsList.Add(upperLetters[24]);
							break;
						case 'Z':
							builder.itemsList.Add(upperLetters[25]);
							break;
						
				}
				
				Debug.Log(letter);
			}
			
		}
		builder.WipeEverything();
		builder.LoadLetters();
		builder.SaveWord();
		builder.BuildWords(false);
		
	}
}
