// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-06-06 12:10:25

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
    // TT\\Template.g:80:1: statement : ( getExpr | setExpr );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);



        try 
    	{
            // TT\\Template.g:81:2: ( getExpr | setExpr )
            int alt2 = 2;
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
    // TT\\Template.g:85:1: getExpr : ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal7 = null;
        IToken ID8 = null;
        IToken string_literal9 = null;
        IToken LITERAL10 = null;
        IToken string_literal11 = null;
        IToken ILITERAL12 = null;

        CommonTree string_literal7_tree=null;
        CommonTree ID8_tree=null;
        CommonTree string_literal9_tree=null;
        CommonTree LITERAL10_tree=null;
        CommonTree string_literal11_tree=null;
        CommonTree ILITERAL12_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try 
    	{
            // TT\\Template.g:86:2: ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case 55:
            	{
                switch ( input.LA(2) ) 
                {
                case ILITERAL:
                	{
                    alt6 = 3;
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
                    // TT\\Template.g:86:4: ( 'GET' )? ID
                    {
                    	// TT\\Template.g:86:4: ( 'GET' )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 55) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:86:4: 'GET'
                    	        {
                    	        	string_literal7=(IToken)Match(input,55,FOLLOW_55_in_getExpr522);  
                    	        	stream_55.Add(string_literal7);


                    	        }
                    	        break;

                    	}

                    	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr525);  
                    	stream_ID.Add(ID8);



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
                    	// 86:20: -> ^( GET ID )
                    	{
                    	    // TT\\Template.g:86:23: ^( GET ID )
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
                    // TT\\Template.g:87:4: ( 'GET' )? LITERAL
                    {
                    	// TT\\Template.g:87:4: ( 'GET' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 55) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:87:4: 'GET'
                    	        {
                    	        	string_literal9=(IToken)Match(input,55,FOLLOW_55_in_getExpr544);  
                    	        	stream_55.Add(string_literal9);


                    	        }
                    	        break;

                    	}

                    	LITERAL10=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr547);  
                    	stream_LITERAL.Add(LITERAL10);



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
                    	// 87:20: -> ^( GET LITERAL )
                    	{
                    	    // TT\\Template.g:87:23: ^( GET LITERAL )
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
                    // TT\\Template.g:88:4: ( 'GET' )? ILITERAL
                    {
                    	// TT\\Template.g:88:4: ( 'GET' )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 55) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:88:4: 'GET'
                    	        {
                    	        	string_literal11=(IToken)Match(input,55,FOLLOW_55_in_getExpr561);  
                    	        	stream_55.Add(string_literal11);


                    	        }
                    	        break;

                    	}

                    	ILITERAL12=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr564);  
                    	stream_ILITERAL.Add(ILITERAL12);



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
                    	// 88:20: -> ^( GET ILITERAL )
                    	{
                    	    // TT\\Template.g:88:23: ^( GET ILITERAL )
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
    // TT\\Template.g:91:1: setExpr : ( ( 'SET' )? ID ASSIGN LITERAL -> ^( SET ID LITERAL ) | ( 'SET' )? ID ASSIGN NUMBER -> ^( SET ID NUMBER ) | ( 'SET' )? ID ASSIGN DECIMAL -> ^( SET ID DECIMAL ) );
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal13 = null;
        IToken ID14 = null;
        IToken ASSIGN15 = null;
        IToken LITERAL16 = null;
        IToken string_literal17 = null;
        IToken ID18 = null;
        IToken ASSIGN19 = null;
        IToken NUMBER20 = null;
        IToken string_literal21 = null;
        IToken ID22 = null;
        IToken ASSIGN23 = null;
        IToken DECIMAL24 = null;

        CommonTree string_literal13_tree=null;
        CommonTree ID14_tree=null;
        CommonTree ASSIGN15_tree=null;
        CommonTree LITERAL16_tree=null;
        CommonTree string_literal17_tree=null;
        CommonTree ID18_tree=null;
        CommonTree ASSIGN19_tree=null;
        CommonTree NUMBER20_tree=null;
        CommonTree string_literal21_tree=null;
        CommonTree ID22_tree=null;
        CommonTree ASSIGN23_tree=null;
        CommonTree DECIMAL24_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_DECIMAL = new RewriteRuleTokenStream(adaptor,"token DECIMAL");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");

        try 
    	{
            // TT\\Template.g:92:2: ( ( 'SET' )? ID ASSIGN LITERAL -> ^( SET ID LITERAL ) | ( 'SET' )? ID ASSIGN NUMBER -> ^( SET ID NUMBER ) | ( 'SET' )? ID ASSIGN DECIMAL -> ^( SET ID DECIMAL ) )
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
                    // TT\\Template.g:92:4: ( 'SET' )? ID ASSIGN LITERAL
                    {
                    	// TT\\Template.g:92:4: ( 'SET' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 56) )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:92:4: 'SET'
                    	        {
                    	        	string_literal13=(IToken)Match(input,56,FOLLOW_56_in_setExpr583);  
                    	        	stream_56.Add(string_literal13);


                    	        }
                    	        break;

                    	}

                    	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr586);  
                    	stream_ID.Add(ID14);

                    	ASSIGN15=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr588);  
                    	stream_ASSIGN.Add(ASSIGN15);

                    	LITERAL16=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_setExpr590);  
                    	stream_LITERAL.Add(LITERAL16);



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
                    	// 92:29: -> ^( SET ID LITERAL )
                    	{
                    	    // TT\\Template.g:92:32: ^( SET ID LITERAL )
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
                    // TT\\Template.g:93:4: ( 'SET' )? ID ASSIGN NUMBER
                    {
                    	// TT\\Template.g:93:4: ( 'SET' )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == 56) )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:93:4: 'SET'
                    	        {
                    	        	string_literal17=(IToken)Match(input,56,FOLLOW_56_in_setExpr605);  
                    	        	stream_56.Add(string_literal17);


                    	        }
                    	        break;

                    	}

                    	ID18=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr608);  
                    	stream_ID.Add(ID18);

                    	ASSIGN19=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr610);  
                    	stream_ASSIGN.Add(ASSIGN19);

                    	NUMBER20=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_setExpr612);  
                    	stream_NUMBER.Add(NUMBER20);



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
                    	// 93:29: -> ^( SET ID NUMBER )
                    	{
                    	    // TT\\Template.g:93:32: ^( SET ID NUMBER )
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
                    // TT\\Template.g:94:4: ( 'SET' )? ID ASSIGN DECIMAL
                    {
                    	// TT\\Template.g:94:4: ( 'SET' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == 56) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:94:4: 'SET'
                    	        {
                    	        	string_literal21=(IToken)Match(input,56,FOLLOW_56_in_setExpr628);  
                    	        	stream_56.Add(string_literal21);


                    	        }
                    	        break;

                    	}

                    	ID22=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr631);  
                    	stream_ID.Add(ID22);

                    	ASSIGN23=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr633);  
                    	stream_ASSIGN.Add(ASSIGN23);

                    	DECIMAL24=(IToken)Match(input,DECIMAL,FOLLOW_DECIMAL_in_setExpr635);  
                    	stream_DECIMAL.Add(DECIMAL24);



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
                    	// 94:29: -> ^( SET ID DECIMAL )
                    	{
                    	    // TT\\Template.g:94:32: ^( SET ID DECIMAL )
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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_document467 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTART_in_block488 = new BitSet(new ulong[]{0x0180200000006000UL});
    public static readonly BitSet FOLLOW_statement_in_block491 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr522 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr544 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_getExpr561 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr583 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr586 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr588 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_setExpr590 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr605 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr608 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr610 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_setExpr612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_setExpr628 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr631 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr633 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_setExpr635 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}