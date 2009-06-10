// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-06-09 21:30:29

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

namespace TT
{
public partial class TemplateParser : Parser
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
    public const int CHAR = 54;
    public const int RAWPERL = 34;
    public const int SUB = 49;
    public const int ID = 45;
    public const int EOF = -1;
    public const int TSTART = 9;
    public const int IF = 24;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int QUOTE = 11;
    public const int TSTOP = 10;
    public const int FINAL = 38;
    public const int COMMENTS = 44;
    public const int INSERT = 17;
    public const int DOCUMENT = 7;
    public const int EQUAL = 53;
    public const int INCLUDE = 19;
    public const int RETURN = 41;
    public const int GET = 4;
    public const int NEXT = 39;
    public const int LAST = 40;
    public const int UNLESS = 25;
    public const int ILITERAL = 13;
    public const int ADD = 48;
    public const int SWITCH = 28;
    public const int DEFAULT = 16;
    public const int ELSE = 27;
    public const int NUMBER = 46;
    public const int TAGS = 43;
    public const int STOP = 42;
    public const int LITERAL = 14;
    public const int SET = 5;
    public const int MULT = 50;
    public const int SQUOTE = 12;
    public const int WRAPPER = 20;
    public const int PRINT = 6;
    public const int TRY = 35;
    public const int PERL = 33;
    public const int WS = 8;
    public const int DECIMAL = 47;
    public const int BLOCK = 21;
    public const int ASSIGN = 52;
    public const int FILTER = 31;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int ELSIF = 26;
    public const int USE = 32;
    public const int DIV = 51;
    public const int PROCESS = 18;
    public const int CATCH = 37;
    public const int MACRO = 30;
    public const int THROW = 36;

    // delegates
    // delegators



        public TemplateParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public TemplateParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return TemplateParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "TT\\Template.g"; }
    }


    public class document_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "document"
    // TT\\Template.g:72:1: document : ( block )* -> ^( DOCUMENT ( block )* ) ;
    public TemplateParser.document_return document() // throws RecognitionException [1]
    {   
        TemplateParser.document_return retval = new TemplateParser.document_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.block_return block1 = default(TemplateParser.block_return);


        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        try 
    	{
            // TT\\Template.g:73:2: ( ( block )* -> ^( DOCUMENT ( block )* ) )
            // TT\\Template.g:73:4: ( block )*
            {
            	// TT\\Template.g:73:4: ( block )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == TSTART) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // TT\\Template.g:73:4: block
            			    {
            			    	PushFollow(FOLLOW_block_in_document467);
            			    	block1 = block();
            			    	state.followingStackPointer--;

            			    	stream_block.Add(block1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 73:11: -> ^( DOCUMENT ( block )* )
            	{
            	    // TT\\Template.g:73:14: ^( DOCUMENT ( block )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DOCUMENT, "DOCUMENT"), root_1);

            	    // TT\\Template.g:73:25: ( block )*
            	    while ( stream_block.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_block.NextTree());

            	    }
            	    stream_block.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "document"

    public class block_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "block"
    // TT\\Template.g:76:1: block : TSTART statement TSTOP ;
    public TemplateParser.block_return block() // throws RecognitionException [1]
    {   
        TemplateParser.block_return retval = new TemplateParser.block_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TSTART2 = null;
        IToken TSTOP4 = null;
        TemplateParser.statement_return statement3 = default(TemplateParser.statement_return);


        CommonTree TSTART2_tree=null;
        CommonTree TSTOP4_tree=null;

        try 
    	{
            // TT\\Template.g:77:2: ( TSTART statement TSTOP )
            // TT\\Template.g:77:4: TSTART statement TSTOP
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	TSTART2=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_block488); 
            	PushFollow(FOLLOW_statement_in_block491);
            	statement3 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement3.Tree);
            	TSTOP4=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_block493); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class statement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // TT\\Template.g:80:1: statement : ( getExpr | setExpr | defaultExpr );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);

        TemplateParser.defaultExpr_return defaultExpr7 = default(TemplateParser.defaultExpr_return);



        try 
    	{
            // TT\\Template.g:81:2: ( getExpr | setExpr | defaultExpr )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case ILITERAL:
            case LITERAL:
            case 55:
            	{
                alt2 = 1;
                }
                break;
            case ID:
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == ASSIGN) )
                {
                    alt2 = 2;
                }
                else if ( (LA2_2 == TSTOP) )
                {
                    alt2 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
                }
                break;
            case 56:
            	{
                alt2 = 2;
                }
                break;
            case DEFAULT:
            	{
                alt2 = 3;
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
                    // TT\\Template.g:81:4: getExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_getExpr_in_statement506);
                    	getExpr5 = getExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, getExpr5.Tree);

                    }
                    break;
                case 2 :
                    // TT\\Template.g:82:4: setExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setExpr_in_statement511);
                    	setExpr6 = setExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, setExpr6.Tree);

                    }
                    break;
                case 3 :
                    // TT\\Template.g:83:4: defaultExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defaultExpr_in_statement516);
                    	defaultExpr7 = defaultExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, defaultExpr7.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class getExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "getExpr"
    // TT\\Template.g:86:1: getExpr : ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal8 = null;
        IToken ID9 = null;
        IToken string_literal10 = null;
        IToken LITERAL11 = null;
        IToken string_literal12 = null;
        IToken ILITERAL13 = null;

        CommonTree string_literal8_tree=null;
        CommonTree ID9_tree=null;
        CommonTree string_literal10_tree=null;
        CommonTree LITERAL11_tree=null;
        CommonTree string_literal12_tree=null;
        CommonTree ILITERAL13_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try 
    	{
            // TT\\Template.g:87:2: ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case 55:
            	{
                switch ( input.LA(2) ) 
                {
                case LITERAL:
                	{
                    alt6 = 2;
                    }
                    break;
                case ID:
                	{
                    alt6 = 1;
                    }
                    break;
                case ILITERAL:
                	{
                    alt6 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d6s1 =
                	        new NoViableAltException("", 6, 1, input);

                	    throw nvae_d6s1;
                }

                }
                break;
            case ID:
            	{
                alt6 = 1;
                }
                break;
            case LITERAL:
            	{
                alt6 = 2;
                }
                break;
            case ILITERAL:
            	{
                alt6 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // TT\\Template.g:87:4: ( 'GET' )? ID
                    {
                    	// TT\\Template.g:87:4: ( 'GET' )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 55) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:87:4: 'GET'
                    	        {
                    	        	string_literal8=(IToken)Match(input,55,FOLLOW_55_in_getExpr527);  
                    	        	stream_55.Add(string_literal8);


                    	        }
                    	        break;

                    	}

                    	ID9=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr530);  
                    	stream_ID.Add(ID9);



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 87:20: -> ^( GET ID )
                    	{
                    	    // TT\\Template.g:87:23: ^( GET ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:88:4: ( 'GET' )? LITERAL
                    {
                    	// TT\\Template.g:88:4: ( 'GET' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 55) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:88:4: 'GET'
                    	        {
                    	        	string_literal10=(IToken)Match(input,55,FOLLOW_55_in_getExpr549);  
                    	        	stream_55.Add(string_literal10);


                    	        }
                    	        break;

                    	}

                    	LITERAL11=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr552);  
                    	stream_LITERAL.Add(LITERAL11);



                    	// AST REWRITE
                    	// elements:          LITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 88:20: -> ^( GET LITERAL )
                    	{
                    	    // TT\\Template.g:88:23: ^( GET LITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_LITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:89:4: ( 'GET' )? ILITERAL
                    {
                    	// TT\\Template.g:89:4: ( 'GET' )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 55) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:89:4: 'GET'
                    	        {
                    	        	string_literal12=(IToken)Match(input,55,FOLLOW_55_in_getExpr566);  
                    	        	stream_55.Add(string_literal12);


                    	        }
                    	        break;

                    	}

                    	ILITERAL13=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr569);  
                    	stream_ILITERAL.Add(ILITERAL13);



                    	// AST REWRITE
                    	// elements:          ILITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 89:20: -> ^( GET ILITERAL )
                    	{
                    	    // TT\\Template.g:89:23: ^( GET ILITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ILITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "getExpr"

    public class setExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "setExpr"
    // TT\\Template.g:92:1: setExpr : ( ( 'SET' )? ID ASSIGN LITERAL -> ^( SET ID LITERAL ) | ( 'SET' )? ID ASSIGN NUMBER -> ^( SET ID NUMBER ) | ( 'SET' )? ID ASSIGN DECIMAL -> ^( SET ID DECIMAL ) );
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal14 = null;
        IToken ID15 = null;
        IToken ASSIGN16 = null;
        IToken LITERAL17 = null;
        IToken string_literal18 = null;
        IToken ID19 = null;
        IToken ASSIGN20 = null;
        IToken NUMBER21 = null;
        IToken string_literal22 = null;
        IToken ID23 = null;
        IToken ASSIGN24 = null;
        IToken DECIMAL25 = null;

        CommonTree string_literal14_tree=null;
        CommonTree ID15_tree=null;
        CommonTree ASSIGN16_tree=null;
        CommonTree LITERAL17_tree=null;
        CommonTree string_literal18_tree=null;
        CommonTree ID19_tree=null;
        CommonTree ASSIGN20_tree=null;
        CommonTree NUMBER21_tree=null;
        CommonTree string_literal22_tree=null;
        CommonTree ID23_tree=null;
        CommonTree ASSIGN24_tree=null;
        CommonTree DECIMAL25_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_DECIMAL = new RewriteRuleTokenStream(adaptor,"token DECIMAL");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");

        try 
    	{
            // TT\\Template.g:93:2: ( ( 'SET' )? ID ASSIGN LITERAL -> ^( SET ID LITERAL ) | ( 'SET' )? ID ASSIGN NUMBER -> ^( SET ID NUMBER ) | ( 'SET' )? ID ASSIGN DECIMAL -> ^( SET ID DECIMAL ) )
            int alt10 = 3;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == 56) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == ID) )
                {
                    int LA10_2 = input.LA(3);

                    if ( (LA10_2 == ASSIGN) )
                    {
                        switch ( input.LA(4) ) 
                        {
                        case LITERAL:
                        	{
                            alt10 = 1;
                            }
                            break;
                        case NUMBER:
                        	{
                            alt10 = 2;
                            }
                            break;
                        case DECIMAL:
                        	{
                            alt10 = 3;
                            }
                            break;
                        	default:
                        	    NoViableAltException nvae_d10s3 =
                        	        new NoViableAltException("", 10, 3, input);

                        	    throw nvae_d10s3;
                        }

                    }
                    else 
                    {
                        NoViableAltException nvae_d10s2 =
                            new NoViableAltException("", 10, 2, input);

                        throw nvae_d10s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else if ( (LA10_0 == ID) )
            {
                int LA10_2 = input.LA(2);

                if ( (LA10_2 == ASSIGN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case LITERAL:
                    	{
                        alt10 = 1;
                        }
                        break;
                    case NUMBER:
                    	{
                        alt10 = 2;
                        }
                        break;
                    case DECIMAL:
                    	{
                        alt10 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d10s3 =
                    	        new NoViableAltException("", 10, 3, input);

                    	    throw nvae_d10s3;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d10s2 =
                        new NoViableAltException("", 10, 2, input);

                    throw nvae_d10s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // TT\\Template.g:93:4: ( 'SET' )? ID ASSIGN LITERAL
                    {
                    	// TT\\Template.g:93:4: ( 'SET' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 56) )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:93:4: 'SET'
                    	        {
                    	        	string_literal14=(IToken)Match(input,56,FOLLOW_56_in_setExpr588);  
                    	        	stream_56.Add(string_literal14);


                    	        }
                    	        break;

                    	}

                    	ID15=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr591);  
                    	stream_ID.Add(ID15);

                    	ASSIGN16=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr593);  
                    	stream_ASSIGN.Add(ASSIGN16);

                    	LITERAL17=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_setExpr595);  
                    	stream_LITERAL.Add(LITERAL17);



                    	// AST REWRITE
                    	// elements:          LITERAL, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 93:29: -> ^( SET ID LITERAL )
                    	{
                    	    // TT\\Template.g:93:32: ^( SET ID LITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SET, "SET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_LITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:94:4: ( 'SET' )? ID ASSIGN NUMBER
                    {
                    	// TT\\Template.g:94:4: ( 'SET' )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == 56) )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:94:4: 'SET'
                    	        {
                    	        	string_literal18=(IToken)Match(input,56,FOLLOW_56_in_setExpr610);  
                    	        	stream_56.Add(string_literal18);


                    	        }
                    	        break;

                    	}

                    	ID19=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr613);  
                    	stream_ID.Add(ID19);

                    	ASSIGN20=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr615);  
                    	stream_ASSIGN.Add(ASSIGN20);

                    	NUMBER21=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_setExpr617);  
                    	stream_NUMBER.Add(NUMBER21);



                    	// AST REWRITE
                    	// elements:          ID, NUMBER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 94:29: -> ^( SET ID NUMBER )
                    	{
                    	    // TT\\Template.g:94:32: ^( SET ID NUMBER )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SET, "SET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_NUMBER.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:95:4: ( 'SET' )? ID ASSIGN DECIMAL
                    {
                    	// TT\\Template.g:95:4: ( 'SET' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == 56) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:95:4: 'SET'
                    	        {
                    	        	string_literal22=(IToken)Match(input,56,FOLLOW_56_in_setExpr633);  
                    	        	stream_56.Add(string_literal22);


                    	        }
                    	        break;

                    	}

                    	ID23=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr636);  
                    	stream_ID.Add(ID23);

                    	ASSIGN24=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr638);  
                    	stream_ASSIGN.Add(ASSIGN24);

                    	DECIMAL25=(IToken)Match(input,DECIMAL,FOLLOW_DECIMAL_in_setExpr640);  
                    	stream_DECIMAL.Add(DECIMAL25);



                    	// AST REWRITE
                    	// elements:          DECIMAL, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 95:29: -> ^( SET ID DECIMAL )
                    	{
                    	    // TT\\Template.g:95:32: ^( SET ID DECIMAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SET, "SET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_DECIMAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setExpr"

    public class defaultExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defaultExpr"
    // TT\\Template.g:98:1: defaultExpr : DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ ;
    public TemplateParser.defaultExpr_return defaultExpr() // throws RecognitionException [1]
    {   
        TemplateParser.defaultExpr_return retval = new TemplateParser.defaultExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DEFAULT26 = null;
        TemplateParser.assignment_return assignment27 = default(TemplateParser.assignment_return);


        CommonTree DEFAULT26_tree=null;
        RewriteRuleTokenStream stream_DEFAULT = new RewriteRuleTokenStream(adaptor,"token DEFAULT");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // TT\\Template.g:99:2: ( DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ )
            // TT\\Template.g:99:4: DEFAULT ( assignment )+
            {
            	DEFAULT26=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr661);  
            	stream_DEFAULT.Add(DEFAULT26);

            	// TT\\Template.g:99:12: ( assignment )+
            	int cnt11 = 0;
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == ID) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // TT\\Template.g:99:13: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_defaultExpr664);
            			    	assignment27 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment27.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt11 >= 1 ) goto loop11;
            		            EarlyExitException eee11 =
            		                new EarlyExitException(11, input);
            		            throw eee11;
            	    }
            	    cnt11++;
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements



            	// AST REWRITE
            	// elements:          assignment, DEFAULT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 99:26: -> ( ^( DEFAULT assignment ) )+
            	{
            	    if ( !(stream_assignment.HasNext() || stream_DEFAULT.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_assignment.HasNext() || stream_DEFAULT.HasNext() )
            	    {
            	        // TT\\Template.g:99:29: ^( DEFAULT assignment )
            	        {
            	        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        root_1 = (CommonTree)adaptor.BecomeRoot(stream_DEFAULT.NextNode(), root_1);

            	        adaptor.AddChild(root_1, stream_assignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_assignment.Reset();
            	    stream_DEFAULT.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defaultExpr"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // TT\\Template.g:102:1: assignment : ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL );
    public TemplateParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        TemplateParser.assignment_return retval = new TemplateParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID28 = null;
        IToken ASSIGN29 = null;
        IToken LITERAL30 = null;
        IToken ID31 = null;
        IToken ASSIGN32 = null;
        IToken NUMBER33 = null;
        IToken ID34 = null;
        IToken ASSIGN35 = null;
        IToken DECIMAL36 = null;

        CommonTree ID28_tree=null;
        CommonTree ASSIGN29_tree=null;
        CommonTree LITERAL30_tree=null;
        CommonTree ID31_tree=null;
        CommonTree ASSIGN32_tree=null;
        CommonTree NUMBER33_tree=null;
        CommonTree ID34_tree=null;
        CommonTree ASSIGN35_tree=null;
        CommonTree DECIMAL36_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_DECIMAL = new RewriteRuleTokenStream(adaptor,"token DECIMAL");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");

        try 
    	{
            // TT\\Template.g:103:2: ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL )
            int alt12 = 3;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == ID) )
            {
                int LA12_1 = input.LA(2);

                if ( (LA12_1 == ASSIGN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case LITERAL:
                    	{
                        alt12 = 1;
                        }
                        break;
                    case NUMBER:
                    	{
                        alt12 = 2;
                        }
                        break;
                    case DECIMAL:
                    	{
                        alt12 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d12s2 =
                    	        new NoViableAltException("", 12, 2, input);

                    	    throw nvae_d12s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d12s1 =
                        new NoViableAltException("", 12, 1, input);

                    throw nvae_d12s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // TT\\Template.g:103:4: ID ASSIGN LITERAL
                    {
                    	ID28=(IToken)Match(input,ID,FOLLOW_ID_in_assignment686);  
                    	stream_ID.Add(ID28);

                    	ASSIGN29=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment688);  
                    	stream_ASSIGN.Add(ASSIGN29);

                    	LITERAL30=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_assignment690);  
                    	stream_LITERAL.Add(LITERAL30);



                    	// AST REWRITE
                    	// elements:          LITERAL, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 103:22: -> ID LITERAL
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_LITERAL.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:104:4: ID ASSIGN NUMBER
                    {
                    	ID31=(IToken)Match(input,ID,FOLLOW_ID_in_assignment701);  
                    	stream_ID.Add(ID31);

                    	ASSIGN32=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment703);  
                    	stream_ASSIGN.Add(ASSIGN32);

                    	NUMBER33=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_assignment705);  
                    	stream_NUMBER.Add(NUMBER33);



                    	// AST REWRITE
                    	// elements:          ID, NUMBER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 104:22: -> ID NUMBER
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_NUMBER.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:105:4: ID ASSIGN DECIMAL
                    {
                    	ID34=(IToken)Match(input,ID,FOLLOW_ID_in_assignment717);  
                    	stream_ID.Add(ID34);

                    	ASSIGN35=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment719);  
                    	stream_ASSIGN.Add(ASSIGN35);

                    	DECIMAL36=(IToken)Match(input,DECIMAL,FOLLOW_DECIMAL_in_assignment721);  
                    	stream_DECIMAL.Add(DECIMAL36);



                    	// AST REWRITE
                    	// elements:          DECIMAL, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 105:22: -> ID DECIMAL
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_DECIMAL.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_document467 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTART_in_block488 = new BitSet(new ulong[]{0x0180200000016000UL});
    public static readonly BitSet FOLLOW_statement_in_block491 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defaultExpr_in_statement516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr527 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr549 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr566 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr588 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr591 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr593 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_setExpr595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr610 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr613 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr615 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_setExpr617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr633 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr636 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr638 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_setExpr640 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr661 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_defaultExpr664 = new BitSet(new ulong[]{0x0000200000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment686 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment688 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_assignment690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment701 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment703 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_assignment705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment717 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment719 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_assignment721 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}