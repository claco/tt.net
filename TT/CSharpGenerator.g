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
	;

getExpr
	: ^(GET LITERAL) -> print(literal={$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace("\r\n", "\\r\\n")})
	| ^(GET ID) -> getVariable(name={$ID.text})
	;
