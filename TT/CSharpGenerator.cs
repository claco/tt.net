// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\CSharpGenerator.g 2009-06-11 21:44:39

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using Hashtable = System.Collections.Hashtable;
namespace TT
{
public partial class CSharpGenerator : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"GET", 
		"SET", 
		"PRINT", 
		"DOCUMENT", 
		"WS", 
		"TSTART", 
		"TSTOP", 
		"QUOTE", 
		"SQUOTE", 
		"ILITERAL", 
		"LITERAL", 
		"CALL", 
		"DEFAULT", 
		"INSERT", 
		"PROCESS", 
		"INCLUDE", 
		"WRAPPER", 
		"BLOCK", 
		"FOREACH", 
		"WHILE", 
		"IF", 
		"UNLESS", 
		"ELSIF", 
		"ELSE", 
		"SWITCH", 
		"CASE", 
		"MACRO", 
		"FILTER", 
		"USE", 
		"PERL", 
		"RAWPERL", 
		"TRY", 
		"THROW", 
		"CATCH", 
		"FINAL", 
		"NEXT", 
		"LAST", 
		"RETURN", 
		"STOP", 
		"TAGS", 
		"COMMENTS", 
		"END", 
		"ID", 
		"NUMBER", 
		"DECIMAL", 
		"ADD", 
		"SUB", 
		"MULT", 
		"DIV", 
		"ASSIGN", 
		"EQUAL", 
		"CHAR", 
		"'GET'", 
		"'SET'"
    };

    public const int WHILE = 23;
    public const int CASE = 29;
    public const int CHAR = 55;
    public const int RAWPERL = 34;
    public const int SUB = 50;
    public const int ID = 46;
    public const int EOF = -1;
    public const int IF = 24;
    public const int TSTART = 9;
    public const int T__56 = 56;
    public const int FINAL = 38;
    public const int T__57 = 57;
    public const int TSTOP = 10;
    public const int QUOTE = 11;
    public const int INSERT = 17;
    public const int COMMENTS = 44;
    public const int DOCUMENT = 7;
    public const int EQUAL = 54;
    public const int INCLUDE = 19;
    public const int RETURN = 41;
    public const int GET = 4;
    public const int NEXT = 39;
    public const int LAST = 40;
    public const int UNLESS = 25;
    public const int ILITERAL = 13;
    public const int ADD = 49;
    public const int SWITCH = 28;
    public const int DEFAULT = 16;
    public const int ELSE = 27;
    public const int NUMBER = 47;
    public const int TAGS = 43;
    public const int STOP = 42;
    public const int LITERAL = 14;
    public const int SET = 5;
    public const int MULT = 51;
    public const int SQUOTE = 12;
    public const int WRAPPER = 20;
    public const int PRINT = 6;
    public const int TRY = 35;
    public const int PERL = 33;
    public const int WS = 8;
    public const int DECIMAL = 48;
    public const int BLOCK = 21;
    public const int FILTER = 31;
    public const int ASSIGN = 53;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int USE = 32;
    public const int ELSIF = 26;
    public const int DIV = 52;
    public const int CATCH = 37;
    public const int PROCESS = 18;
    public const int END = 45;
    public const int MACRO = 30;
    public const int THROW = 36;

    // delegates
    // delegators



        public CSharpGenerator(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CSharpGenerator(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("CSharpGeneratorTemplates", typeof(AngleBracketTemplateLexer));

    public StringTemplateGroup TemplateLib
    {
     	get { return this.templateLib; }
     	set { this.templateLib = value; }
    }

    /// <summary> Allows convenient multi-value initialization:
    ///  "new STAttrMap().Add(...).Add(...)"
    /// </summary>
    protected class STAttrMap : Hashtable
    {
      public STAttrMap Add(string attrName, object value) 
      {
        base.Add(attrName, value);
        return this;
      }
      public STAttrMap Add(string attrName, int value) 
      {
        base.Add(attrName, value);
        return this;
      }
    }

    override public string[] TokenNames {
		get { return CSharpGenerator.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "TT\\CSharpGenerator.g"; }
    }


    public class document_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "document"
    // TT\\CSharpGenerator.g:13:1: document : ^( DOCUMENT (stmts+= statement )* ) -> class(statements=$stmts);
    public CSharpGenerator.document_return document() // throws RecognitionException [1]
    {   
        CSharpGenerator.document_return retval = new CSharpGenerator.document_return();
        retval.Start = input.LT(1);

        IList list_stmts = null;
        CSharpGenerator.statement_return stmts = default(CSharpGenerator.statement_return);
         stmts = null;
        try 
    	{
            // TT\\CSharpGenerator.g:14:2: ( ^( DOCUMENT (stmts+= statement )* ) -> class(statements=$stmts))
            // TT\\CSharpGenerator.g:14:4: ^( DOCUMENT (stmts+= statement )* )
            {
            	Match(input,DOCUMENT,FOLLOW_DOCUMENT_in_document49); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // TT\\CSharpGenerator.g:14:20: (stmts+= statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( ((LA1_0 >= GET && LA1_0 <= SET) || LA1_0 == DEFAULT || LA1_0 == IF) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // TT\\CSharpGenerator.g:14:20: stmts+= statement
            	    		    {
            	    		    	PushFollow(FOLLOW_statement_in_document53);
            	    		    	stmts = statement();
            	    		    	state.followingStackPointer--;

            	    		    	if (list_stmts == null) list_stmts = new ArrayList();
            	    		    	list_stmts.Add(stmts.Template);


            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop1;
            	        }
            	    } while (true);

            	    loop1:
            	    	;	// Stops C# compiler whining that label 'loop1' has no statements


            	    Match(input, Token.UP, null); 
            	}


            	// TEMPLATE REWRITE
            	// 14:34: -> class(statements=$stmts)
            	{
            	    retval.ST = templateLib.GetInstanceOf("class",
            	  new STAttrMap().Add("statements", list_stmts));
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "document"

    public class statement_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "statement"
    // TT\\CSharpGenerator.g:17:1: statement : ( getExpr -> {$getExpr.st} | setExpr -> {$setExpr.st} | defaultExpr -> {$defaultExpr.st} | ifStatement -> {$ifStatement.st});
    public CSharpGenerator.statement_return statement() // throws RecognitionException [1]
    {   
        CSharpGenerator.statement_return retval = new CSharpGenerator.statement_return();
        retval.Start = input.LT(1);

        CSharpGenerator.getExpr_return getExpr1 = default(CSharpGenerator.getExpr_return);

        CSharpGenerator.setExpr_return setExpr2 = default(CSharpGenerator.setExpr_return);

        CSharpGenerator.defaultExpr_return defaultExpr3 = default(CSharpGenerator.defaultExpr_return);

        CSharpGenerator.ifStatement_return ifStatement4 = default(CSharpGenerator.ifStatement_return);


        try 
    	{
            // TT\\CSharpGenerator.g:18:2: ( getExpr -> {$getExpr.st} | setExpr -> {$setExpr.st} | defaultExpr -> {$defaultExpr.st} | ifStatement -> {$ifStatement.st})
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case GET:
            	{
                alt2 = 1;
                }
                break;
            case SET:
            	{
                alt2 = 2;
                }
                break;
            case DEFAULT:
            	{
                alt2 = 3;
                }
                break;
            case IF:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // TT\\CSharpGenerator.g:18:4: getExpr
                    {
                    	PushFollow(FOLLOW_getExpr_in_statement75);
                    	getExpr1 = getExpr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 18:12: -> {$getExpr.st}
                    	{
                    	    retval.ST = ((getExpr1 != null) ? getExpr1.ST : null);
                    	}


                    }
                    break;
                case 2 :
                    // TT\\CSharpGenerator.g:19:4: setExpr
                    {
                    	PushFollow(FOLLOW_setExpr_in_statement84);
                    	setExpr2 = setExpr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 19:12: -> {$setExpr.st}
                    	{
                    	    retval.ST = ((setExpr2 != null) ? setExpr2.ST : null);
                    	}


                    }
                    break;
                case 3 :
                    // TT\\CSharpGenerator.g:20:4: defaultExpr
                    {
                    	PushFollow(FOLLOW_defaultExpr_in_statement93);
                    	defaultExpr3 = defaultExpr();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 20:16: -> {$defaultExpr.st}
                    	{
                    	    retval.ST = ((defaultExpr3 != null) ? defaultExpr3.ST : null);
                    	}


                    }
                    break;
                case 4 :
                    // TT\\CSharpGenerator.g:21:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement102);
                    	ifStatement4 = ifStatement();
                    	state.followingStackPointer--;



                    	// TEMPLATE REWRITE
                    	// 21:16: -> {$ifStatement.st}
                    	{
                    	    retval.ST = ((ifStatement4 != null) ? ifStatement4.ST : null);
                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class ifStatement_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "ifStatement"
    // TT\\CSharpGenerator.g:24:1: ifStatement : ^( IF ID statement ) -> ifVariableStatement(name=$ID.textstatement=$statement.st);
    public CSharpGenerator.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        CSharpGenerator.ifStatement_return retval = new CSharpGenerator.ifStatement_return();
        retval.Start = input.LT(1);

        CommonTree ID5 = null;
        CSharpGenerator.statement_return statement6 = default(CSharpGenerator.statement_return);


        try 
    	{
            // TT\\CSharpGenerator.g:25:2: ( ^( IF ID statement ) -> ifVariableStatement(name=$ID.textstatement=$statement.st))
            // TT\\CSharpGenerator.g:25:4: ^( IF ID statement )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement118); 

            	Match(input, Token.DOWN, null); 
            	ID5=(CommonTree)Match(input,ID,FOLLOW_ID_in_ifStatement120); 
            	PushFollow(FOLLOW_statement_in_ifStatement122);
            	statement6 = statement();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 


            	// TEMPLATE REWRITE
            	// 25:23: -> ifVariableStatement(name=$ID.textstatement=$statement.st)
            	{
            	    retval.ST = templateLib.GetInstanceOf("ifVariableStatement",
            	  new STAttrMap().Add("name", ((ID5 != null) ? ID5.Text : null)).Add("statement", ((statement6 != null) ? statement6.ST : null)));
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifStatement"

    public class getExpr_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "getExpr"
    // TT\\CSharpGenerator.g:28:1: getExpr : ( ^( GET LITERAL ) -> print(literal=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( GET ID ) -> getVariable(name=$ID.Text));
    public CSharpGenerator.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        CSharpGenerator.getExpr_return retval = new CSharpGenerator.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree LITERAL7 = null;
        CommonTree ID8 = null;

        try 
    	{
            // TT\\CSharpGenerator.g:29:2: ( ^( GET LITERAL ) -> print(literal=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( GET ID ) -> getVariable(name=$ID.Text))
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == GET) )
            {
                int LA3_1 = input.LA(2);

                if ( (LA3_1 == DOWN) )
                {
                    int LA3_2 = input.LA(3);

                    if ( (LA3_2 == LITERAL) )
                    {
                        alt3 = 1;
                    }
                    else if ( (LA3_2 == ID) )
                    {
                        alt3 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d3s2 =
                            new NoViableAltException("", 3, 2, input);

                        throw nvae_d3s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d3s1 =
                        new NoViableAltException("", 3, 1, input);

                    throw nvae_d3s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // TT\\CSharpGenerator.g:29:4: ^( GET LITERAL )
                    {
                    	Match(input,GET,FOLLOW_GET_in_getExpr149); 

                    	Match(input, Token.DOWN, null); 
                    	LITERAL7=(CommonTree)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr151); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 29:19: -> print(literal=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\"))
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("print",
                    	  new STAttrMap().Add("literal", LITERAL7.Text.Substring(1, LITERAL7.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")));
                    	}


                    }
                    break;
                case 2 :
                    // TT\\CSharpGenerator.g:30:4: ^( GET ID )
                    {
                    	Match(input,GET,FOLLOW_GET_in_getExpr167); 

                    	Match(input, Token.DOWN, null); 
                    	ID8=(CommonTree)Match(input,ID,FOLLOW_ID_in_getExpr169); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 30:14: -> getVariable(name=$ID.Text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("getVariable",
                    	  new STAttrMap().Add("name", ID8.Text));
                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "getExpr"

    public class setExpr_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "setExpr"
    // TT\\CSharpGenerator.g:33:1: setExpr : ( ^( SET ID LITERAL ) -> setLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( SET ID NUMBER ) -> setNumericVariable(name=$ID.Textnumber=$NUMBER.Text) | ^( SET ID DECIMAL ) -> setDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text));
    public CSharpGenerator.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        CSharpGenerator.setExpr_return retval = new CSharpGenerator.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree ID9 = null;
        CommonTree LITERAL10 = null;
        CommonTree ID11 = null;
        CommonTree NUMBER12 = null;
        CommonTree ID13 = null;
        CommonTree DECIMAL14 = null;

        try 
    	{
            // TT\\CSharpGenerator.g:34:2: ( ^( SET ID LITERAL ) -> setLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( SET ID NUMBER ) -> setNumericVariable(name=$ID.Textnumber=$NUMBER.Text) | ^( SET ID DECIMAL ) -> setDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text))
            int alt4 = 3;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == SET) )
            {
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == DOWN) )
                {
                    int LA4_2 = input.LA(3);

                    if ( (LA4_2 == ID) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case LITERAL:
                        	{
                            alt4 = 1;
                            }
                            break;
                        case NUMBER:
                        	{
                            alt4 = 2;
                            }
                            break;
                        case DECIMAL:
                        	{
                            alt4 = 3;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d4s3 =
                        	        new NoViableAltException("", 4, 3, input);

                        	    throw nvae_d4s3;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d4s2 =
                            new NoViableAltException("", 4, 2, input);

                        throw nvae_d4s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // TT\\CSharpGenerator.g:34:4: ^( SET ID LITERAL )
                    {
                    	Match(input,SET,FOLLOW_SET_in_setExpr191); 

                    	Match(input, Token.DOWN, null); 
                    	ID9=(CommonTree)Match(input,ID,FOLLOW_ID_in_setExpr193); 
                    	LITERAL10=(CommonTree)Match(input,LITERAL,FOLLOW_LITERAL_in_setExpr195); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 34:22: -> setLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\"))
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setLiteralVariable",
                    	  new STAttrMap().Add("name", ID9.Text).Add("literal", LITERAL10.Text.Substring(1, LITERAL10.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")));
                    	}


                    }
                    break;
                case 2 :
                    // TT\\CSharpGenerator.g:35:4: ^( SET ID NUMBER )
                    {
                    	Match(input,SET,FOLLOW_SET_in_setExpr216); 

                    	Match(input, Token.DOWN, null); 
                    	ID11=(CommonTree)Match(input,ID,FOLLOW_ID_in_setExpr218); 
                    	NUMBER12=(CommonTree)Match(input,NUMBER,FOLLOW_NUMBER_in_setExpr220); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 35:22: -> setNumericVariable(name=$ID.Textnumber=$NUMBER.Text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setNumericVariable",
                    	  new STAttrMap().Add("name", ID11.Text).Add("number", NUMBER12.Text));
                    	}


                    }
                    break;
                case 3 :
                    // TT\\CSharpGenerator.g:36:4: ^( SET ID DECIMAL )
                    {
                    	Match(input,SET,FOLLOW_SET_in_setExpr242); 

                    	Match(input, Token.DOWN, null); 
                    	ID13=(CommonTree)Match(input,ID,FOLLOW_ID_in_setExpr244); 
                    	DECIMAL14=(CommonTree)Match(input,DECIMAL,FOLLOW_DECIMAL_in_setExpr246); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 36:22: -> setDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setDecimalVariable",
                    	  new STAttrMap().Add("name", ID13.Text).Add("decimal", DECIMAL14.Text));
                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setExpr"

    public class defaultExpr_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "defaultExpr"
    // TT\\CSharpGenerator.g:39:1: defaultExpr : ( ^( DEFAULT ID LITERAL ) -> setDefaultLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( DEFAULT ID NUMBER ) -> setDefaultNumericVariable(name=$ID.Textnumber=$NUMBER.Text) | ^( DEFAULT ID DECIMAL ) -> setDefaultDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text));
    public CSharpGenerator.defaultExpr_return defaultExpr() // throws RecognitionException [1]
    {   
        CSharpGenerator.defaultExpr_return retval = new CSharpGenerator.defaultExpr_return();
        retval.Start = input.LT(1);

        CommonTree ID15 = null;
        CommonTree LITERAL16 = null;
        CommonTree ID17 = null;
        CommonTree NUMBER18 = null;
        CommonTree ID19 = null;
        CommonTree DECIMAL20 = null;

        try 
    	{
            // TT\\CSharpGenerator.g:40:2: ( ^( DEFAULT ID LITERAL ) -> setDefaultLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\")) | ^( DEFAULT ID NUMBER ) -> setDefaultNumericVariable(name=$ID.Textnumber=$NUMBER.Text) | ^( DEFAULT ID DECIMAL ) -> setDefaultDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text))
            int alt5 = 3;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == DEFAULT) )
            {
                int LA5_1 = input.LA(2);

                if ( (LA5_1 == DOWN) )
                {
                    int LA5_2 = input.LA(3);

                    if ( (LA5_2 == ID) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case LITERAL:
                        	{
                            alt5 = 1;
                            }
                            break;
                        case NUMBER:
                        	{
                            alt5 = 2;
                            }
                            break;
                        case DECIMAL:
                        	{
                            alt5 = 3;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d5s3 =
                        	        new NoViableAltException("", 5, 3, input);

                        	    throw nvae_d5s3;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d5s2 =
                            new NoViableAltException("", 5, 2, input);

                        throw nvae_d5s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d5s1 =
                        new NoViableAltException("", 5, 1, input);

                    throw nvae_d5s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // TT\\CSharpGenerator.g:40:4: ^( DEFAULT ID LITERAL )
                    {
                    	Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr273); 

                    	Match(input, Token.DOWN, null); 
                    	ID15=(CommonTree)Match(input,ID,FOLLOW_ID_in_defaultExpr275); 
                    	LITERAL16=(CommonTree)Match(input,LITERAL,FOLLOW_LITERAL_in_defaultExpr277); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 40:26: -> setDefaultLiteralVariable(name=$ID.Textliteral=$LITERAL.Text.Substring(1, $LITERAL.Text.Length-2).Replace(\"\\r\\n\", \"\\\\r\\\\n\").Replace(\"\\r\", \"\\\\r\").Replace(\"\\n\", \"\\\\n\"))
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setDefaultLiteralVariable",
                    	  new STAttrMap().Add("name", ID15.Text).Add("literal", LITERAL16.Text.Substring(1, LITERAL16.Text.Length-2).Replace("\r\n", "\\r\\n").Replace("\r", "\\r").Replace("\n", "\\n")));
                    	}


                    }
                    break;
                case 2 :
                    // TT\\CSharpGenerator.g:41:4: ^( DEFAULT ID NUMBER )
                    {
                    	Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr298); 

                    	Match(input, Token.DOWN, null); 
                    	ID17=(CommonTree)Match(input,ID,FOLLOW_ID_in_defaultExpr300); 
                    	NUMBER18=(CommonTree)Match(input,NUMBER,FOLLOW_NUMBER_in_defaultExpr302); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 41:26: -> setDefaultNumericVariable(name=$ID.Textnumber=$NUMBER.Text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setDefaultNumericVariable",
                    	  new STAttrMap().Add("name", ID17.Text).Add("number", NUMBER18.Text));
                    	}


                    }
                    break;
                case 3 :
                    // TT\\CSharpGenerator.g:42:4: ^( DEFAULT ID DECIMAL )
                    {
                    	Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr324); 

                    	Match(input, Token.DOWN, null); 
                    	ID19=(CommonTree)Match(input,ID,FOLLOW_ID_in_defaultExpr326); 
                    	DECIMAL20=(CommonTree)Match(input,DECIMAL,FOLLOW_DECIMAL_in_defaultExpr328); 

                    	Match(input, Token.UP, null); 


                    	// TEMPLATE REWRITE
                    	// 42:26: -> setDefaultDecimalVariable(name=$ID.Textdecimal=$DECIMAL.Text)
                    	{
                    	    retval.ST = templateLib.GetInstanceOf("setDefaultDecimalVariable",
                    	  new STAttrMap().Add("name", ID19.Text).Add("decimal", DECIMAL20.Text));
                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defaultExpr"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_DOCUMENT_in_document49 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_document53 = new BitSet(new ulong[]{0x0000000001010038UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement75 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement84 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defaultExpr_in_statement93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement118 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_ifStatement120 = new BitSet(new ulong[]{0x0000000001010038UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement122 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GET_in_getExpr149 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr151 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GET_in_getExpr167 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr169 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SET_in_setExpr191 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr193 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_setExpr195 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SET_in_setExpr216 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr218 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_setExpr220 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_SET_in_setExpr242 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr244 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_setExpr246 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr273 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_defaultExpr275 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_defaultExpr277 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr298 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_defaultExpr300 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_defaultExpr302 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr324 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_defaultExpr326 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_defaultExpr328 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}