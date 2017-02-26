from Files import Files

CONFIG = {
	"entity" : {
		"name" : "Categorias",
		"properties" : {
			# field : type
			"idcategoria" : "int",
			"nombre" : "varchar(50)",
			"descripcion" : "varchar(200)"
		}
	}
}

def makeInsertProcedure(entity):
	""" 
		Make an Insert Store Procedure from a entity object
		
		Input : Entity Dictionary
		Output : string with store procedure codeBase
	"""
	spString = "CREATE PROCEDURE %(SP_NAME)s " \
			" AS "

	return spString

print makeInsertProcedure(CONFIG["entity"])



class MantenimientoMaker:
	def __init__(self):
		pass