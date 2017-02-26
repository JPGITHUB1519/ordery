"""
	Author : Jean Urena
	Date : 25/02/2017
	Module Description:
		File Managament Module
"""

class Files():
	def __init__(self):
		pass

	def openFileAsList(filename):
		""" 
			Open a file and return a list, each element is a line of the file
		"""
		with open(filename) as file:
			content = file.readlines()
		content = [x.strip() for x in content]
		return content

	def appendLineToFile(filename, data):
		"""
			Append a line to a file
		"""
		with open(filename, 'a') as file:
			file.write(data + "\n")

# appendLineToFile("file.txt", "1")
# #print openFileAsList("file.txt")
