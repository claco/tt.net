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
	;

getExpr
	: ^(GET LITERAL) -> print(literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")})
	| ^(GET ID) -> getVariable(name={$ID.text})
	;

setExpr
	: ^(SET ID LITERAL) -> setVariable(name={$ID.text}, literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")})
	;
