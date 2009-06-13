tree grammar CSharpGenerator;

options
{
	output=template;
	language=CSharp2;
	tokenVocab=Template;
	ASTLabelType=CommonTree;
}

@namespace {TT}

document
	: ^(DOCUMENT stmts+=statement*) -> class(statements={$stmts})
	;

statement
	: getExpr -> {$getExpr.st}
	| setExpr -> {$setExpr.st}
	| defaultExpr -> {$defaultExpr.st}
	| ifStatement -> {$ifStatement.st}
	| forEachLoop -> {$forEachLoop.st}
	;

ifStatement
	: ^(IF ID statement) -> ifVariableStatement(name={$ID.text}, statement={$statement.st})
	;

forEachLoop
	: ^(FOREACH ITERATOR=ID VARIABLE=ID statement) -> forEachLoop(iterator={$ITERATOR.text}, variable={$VARIABLE.text}, statement={$statement.st})
	;

getExpr
	: ^(GET LITERAL) -> print(literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")})
	| ^(GET ID) -> getVariable(name={$ID.Text})
	;

setExpr
	: ^(SET ID LITERAL) -> setLiteralVariable(name={$ID.Text}, literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")})
	| ^(SET ID NUMBER)  -> setNumericVariable(name={$ID.Text}, number={$NUMBER.Text})
	| ^(SET ID DECIMAL) -> setDecimalVariable(name={$ID.Text}, decimal={$DECIMAL.Text})
	;

defaultExpr
	: ^(DEFAULT ID LITERAL) -> setDefaultLiteralVariable(name={$ID.Text}, literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")})
	| ^(DEFAULT ID NUMBER)  -> setDefaultNumericVariable(name={$ID.Text}, number={$NUMBER.Text})
	| ^(DEFAULT ID DECIMAL) -> setDefaultDecimalVariable(name={$ID.Text}, decimal={$DECIMAL.Text})
	;
