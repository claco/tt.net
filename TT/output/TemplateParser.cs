// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 C:\\Development\\TT.Net\\TT\\Template.g 2009-05-09 21:00:29

#define ANTLR_DEBUG
// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


using Antlr.Runtime.Debug;
using IOException = System.IO.IOException;

using Antlr.Runtime.Tree;

namespace TT
{
public partial class TemplateParser : DebugParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"GET", 
		"WS", 
		"TSTART", 
		"TSTOP", 
		"QUOTE", 
		"SQUOTE", 
		"ILITERAL", 
		"LITERAL", 
		"SET", 
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
		"DIGIT", 
		"NUMBER", 
		"DECIMAL", 
		"ADD", 
		"SUB", 
		"MULT", 
		"DIV", 
		"ASSIGN", 
		"EQUAL", 
		"CHAR"
    };

    public const int WHILE = 21;
    public const int CASE = 27;
    public const int CHAR = 53;
    public const int RAWPERL = 32;
    public const int SUB = 48;
    public const int ID = 43;
    public const int EOF = -1;
    public const int TSTART = 6;
    public const int IF = 22;
    public const int QUOTE = 8;
    public const int TSTOP = 7;
    public const int FINAL = 36;
    public const int INSERT = 15;
    public const int COMMENTS = 42;
    public const int EQUAL = 52;
    public const int INCLUDE = 17;
    public const int RETURN = 39;
    public const int GET = 4;
    public const int NEXT = 37;
    public const int DIGIT = 44;
    public const int LAST = 38;
    public const int UNLESS = 23;
    public const int ILITERAL = 10;
    public const int ADD = 47;
    public const int SWITCH = 26;
    public const int DEFAULT = 14;
    public const int ELSE = 25;
    public const int NUMBER = 45;
    public const int SET = 12;
    public const int LITERAL = 11;
    public const int STOP = 40;
    public const int TAGS = 41;
    public const int MULT = 49;
    public const int SQUOTE = 9;
    public const int WRAPPER = 18;
    public const int TRY = 33;
    public const int PERL = 31;
    public const int WS = 5;
    public const int DECIMAL = 46;
    public const int BLOCK = 19;
    public const int ASSIGN = 51;
    public const int FILTER = 29;
    public const int FOREACH = 20;
    public const int CALL = 13;
    public const int ELSIF = 24;
    public const int USE = 30;
    public const int DIV = 50;
    public const int PROCESS = 16;
    public const int CATCH = 35;
    public const int MACRO = 28;
    public const int THROW = 34;

    // delegates
    // delegators

    public static readonly string[] ruleNames = new string[] {
        "invalidRule", "getExpr", "statement", "document", "setExpr", "block"
    };
     
        private int ruleLevel = 0;
        public int RuleLevel {
    	get { return ruleLevel; }
        }
        public void IncRuleLevel() { ruleLevel++; }
        public void DecRuleLevel() { ruleLevel--; }
        public TemplateParser(ITokenStream input)
            : this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState()) {
        }

        public TemplateParser(ITokenStream input, int port, RecognizerSharedState state)
            : base(input, state) {
            DebugEventSocketProxy dbg = new DebugEventSocketProxy(this, port, adaptor);
            DebugListener = dbg;
            TokenStream = new DebugTokenStream(input,dbg);
            try {
                dbg.Handshake();
            } catch (IOException ioe) {
                ReportError(ioe);
            }
            InitializeCyclicDFAs(dbg);

            ITreeAdaptor adap = new CommonTreeAdaptor();
            TreeAdaptor = adap;
            dbg.TreeAdaptor = adap;
        }
    public TemplateParser(ITokenStream input, IDebugEventListener dbg)
        : base(input, dbg) {
        InitializeCyclicDFAs(dbg);

         
        ITreeAdaptor adap = new CommonTreeAdaptor();
        TreeAdaptor = adap;

    }
    protected bool EvalPredicate(bool result, string predicate) 
    {
        dbg.SemanticPredicate(result, predicate);
        return result;
    }

    protected DebugTreeAdaptor adaptor;
    public ITreeAdaptor TreeAdaptor
    {
    	get { 
    		return this.adaptor;

    	}
    	set { this.adaptor = new DebugTreeAdaptor(dbg, value); }
    }


    override public string[] TokenNames {
		get { return TemplateParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Development\\TT.Net\\TT\\Template.g"; }
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
    // C:\\Development\\TT.Net\\TT\\Template.g:72:1: document : ( block )* ;
    public TemplateParser.document_return document() // throws RecognitionException [1]
    {   
        TemplateParser.document_return retval = new TemplateParser.document_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.block_return block1 = default(TemplateParser.block_return);



        try {
        	dbg.EnterRule(GrammarFileName, "document");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(72, 1);

        try 
    	{
            // C:\\Development\\TT.Net\\TT\\Template.g:73:2: ( ( block )* )
            dbg.EnterAlt(1);

            // C:\\Development\\TT.Net\\TT\\Template.g:73:4: ( block )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	dbg.Location(73,4);
            	// C:\\Development\\TT.Net\\TT\\Template.g:73:4: ( block )*
            	try { dbg.EnterSubRule(1);

            	do 
            	{
            	    int alt1 = 2;
            	    try { dbg.EnterDecision(1);

            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == TSTART) )
            	    {
            	        alt1 = 1;
            	    }


            	    } finally { dbg.ExitDecision(1); }

            	    switch (alt1) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);

            			    // C:\\Development\\TT.Net\\TT\\Template.g:73:4: block
            			    {
            			    	dbg.Location(73,4);
            			    	PushFollow(FOLLOW_block_in_document479);
            			    	block1 = block();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, block1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements
            	} finally { dbg.ExitSubRule(1); }


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
        dbg.Location(74, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "document");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Development\\TT.Net\\TT\\Template.g:76:1: block : TSTART statement TSTOP ;
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

        try {
        	dbg.EnterRule(GrammarFileName, "block");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(76, 1);

        try 
    	{
            // C:\\Development\\TT.Net\\TT\\Template.g:77:2: ( TSTART statement TSTOP )
            dbg.EnterAlt(1);

            // C:\\Development\\TT.Net\\TT\\Template.g:77:4: TSTART statement TSTOP
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	dbg.Location(77,10);
            	TSTART2=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_block491); 
            	dbg.Location(77,12);
            	PushFollow(FOLLOW_statement_in_block494);
            	statement3 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement3.Tree);
            	dbg.Location(77,27);
            	TSTOP4=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_block496); 

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
        dbg.Location(78, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "block");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Development\\TT.Net\\TT\\Template.g:80:1: statement : ( getExpr | setExpr );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);



        try {
        	dbg.EnterRule(GrammarFileName, "statement");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(80, 1);

        try 
    	{
            // C:\\Development\\TT.Net\\TT\\Template.g:81:2: ( getExpr | setExpr )
            int alt2 = 2;
            try { dbg.EnterDecision(2);

            switch ( input.LA(1) ) 
            {
            case GET:
            case ILITERAL:
            case LITERAL:
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

                    dbg.RecognitionException(nvae_d2s2);
                    throw nvae_d2s2;
                }
                }
                break;
            case SET:
            	{
                alt2 = 2;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    dbg.RecognitionException(nvae_d2s0);
            	    throw nvae_d2s0;
            }

            } finally { dbg.ExitDecision(2); }

            switch (alt2) 
            {
                case 1 :
                    dbg.EnterAlt(1);

                    // C:\\Development\\TT.Net\\TT\\Template.g:81:4: getExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	dbg.Location(81,4);
                    	PushFollow(FOLLOW_getExpr_in_statement509);
                    	getExpr5 = getExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, getExpr5.Tree);

                    }
                    break;
                case 2 :
                    dbg.EnterAlt(2);

                    // C:\\Development\\TT.Net\\TT\\Template.g:82:4: setExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	dbg.Location(82,4);
                    	PushFollow(FOLLOW_setExpr_in_statement514);
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
        dbg.Location(83, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "statement");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Development\\TT.Net\\TT\\Template.g:85:1: getExpr : ( ( GET )? ID -> GET ID | ( GET )? LITERAL -> GET LITERAL | ( GET )? ILITERAL -> GET ILITERAL );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken GET7 = null;
        IToken ID8 = null;
        IToken GET9 = null;
        IToken LITERAL10 = null;
        IToken GET11 = null;
        IToken ILITERAL12 = null;

        CommonTree GET7_tree=null;
        CommonTree ID8_tree=null;
        CommonTree GET9_tree=null;
        CommonTree LITERAL10_tree=null;
        CommonTree GET11_tree=null;
        CommonTree ILITERAL12_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_GET = new RewriteRuleTokenStream(adaptor,"token GET");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try {
        	dbg.EnterRule(GrammarFileName, "getExpr");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(85, 1);

        try 
    	{
            // C:\\Development\\TT.Net\\TT\\Template.g:86:2: ( ( GET )? ID -> GET ID | ( GET )? LITERAL -> GET LITERAL | ( GET )? ILITERAL -> GET ILITERAL )
            int alt6 = 3;
            try { dbg.EnterDecision(6);

            switch ( input.LA(1) ) 
            {
            case GET:
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

                	    dbg.RecognitionException(nvae_d6s1);
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

            	    dbg.RecognitionException(nvae_d6s0);
            	    throw nvae_d6s0;
            }

            } finally { dbg.ExitDecision(6); }

            switch (alt6) 
            {
                case 1 :
                    dbg.EnterAlt(1);

                    // C:\\Development\\TT.Net\\TT\\Template.g:86:4: ( GET )? ID
                    {
                    	dbg.Location(86,4);
                    	// C:\\Development\\TT.Net\\TT\\Template.g:86:4: ( GET )?
                    	int alt3 = 2;
                    	try { dbg.EnterSubRule(3);
                    	try { dbg.EnterDecision(3);

                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == GET) )
                    	{
                    	    alt3 = 1;
                    	}
                    	} finally { dbg.ExitDecision(3); }

                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        dbg.EnterAlt(1);

                    	        // C:\\Development\\TT.Net\\TT\\Template.g:86:4: GET
                    	        {
                    	        	dbg.Location(86,4);
                    	        	GET7=(IToken)Match(input,GET,FOLLOW_GET_in_getExpr525);  
                    	        	stream_GET.Add(GET7);


                    	        }
                    	        break;

                    	}
                    	} finally { dbg.ExitSubRule(3); }

                    	dbg.Location(86,9);
                    	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr528);  
                    	stream_ID.Add(ID8);



                    	// AST REWRITE
                    	// elements:          GET, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 86:12: -> GET ID
                    	{
                    	    dbg.Location(86,15);
                    	    adaptor.AddChild(root_0, stream_GET.NextNode());
                    	    dbg.Location(86,19);
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.EnterAlt(2);

                    // C:\\Development\\TT.Net\\TT\\Template.g:87:4: ( GET )? LITERAL
                    {
                    	dbg.Location(87,4);
                    	// C:\\Development\\TT.Net\\TT\\Template.g:87:4: ( GET )?
                    	int alt4 = 2;
                    	try { dbg.EnterSubRule(4);
                    	try { dbg.EnterDecision(4);

                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == GET) )
                    	{
                    	    alt4 = 1;
                    	}
                    	} finally { dbg.ExitDecision(4); }

                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        dbg.EnterAlt(1);

                    	        // C:\\Development\\TT.Net\\TT\\Template.g:87:4: GET
                    	        {
                    	        	dbg.Location(87,4);
                    	        	GET9=(IToken)Match(input,GET,FOLLOW_GET_in_getExpr539);  
                    	        	stream_GET.Add(GET9);


                    	        }
                    	        break;

                    	}
                    	} finally { dbg.ExitSubRule(4); }

                    	dbg.Location(87,9);
                    	LITERAL10=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr542);  
                    	stream_LITERAL.Add(LITERAL10);



                    	// AST REWRITE
                    	// elements:          GET, LITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 87:17: -> GET LITERAL
                    	{
                    	    dbg.Location(87,20);
                    	    adaptor.AddChild(root_0, stream_GET.NextNode());
                    	    dbg.Location(87,24);
                    	    adaptor.AddChild(root_0, stream_LITERAL.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    dbg.EnterAlt(3);

                    // C:\\Development\\TT.Net\\TT\\Template.g:88:4: ( GET )? ILITERAL
                    {
                    	dbg.Location(88,4);
                    	// C:\\Development\\TT.Net\\TT\\Template.g:88:4: ( GET )?
                    	int alt5 = 2;
                    	try { dbg.EnterSubRule(5);
                    	try { dbg.EnterDecision(5);

                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == GET) )
                    	{
                    	    alt5 = 1;
                    	}
                    	} finally { dbg.ExitDecision(5); }

                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        dbg.EnterAlt(1);

                    	        // C:\\Development\\TT.Net\\TT\\Template.g:88:4: GET
                    	        {
                    	        	dbg.Location(88,4);
                    	        	GET11=(IToken)Match(input,GET,FOLLOW_GET_in_getExpr553);  
                    	        	stream_GET.Add(GET11);


                    	        }
                    	        break;

                    	}
                    	} finally { dbg.ExitSubRule(5); }

                    	dbg.Location(88,9);
                    	ILITERAL12=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr556);  
                    	stream_ILITERAL.Add(ILITERAL12);



                    	// AST REWRITE
                    	// elements:          GET, ILITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 88:18: -> GET ILITERAL
                    	{
                    	    dbg.Location(88,21);
                    	    adaptor.AddChild(root_0, stream_GET.NextNode());
                    	    dbg.Location(88,25);
                    	    adaptor.AddChild(root_0, stream_ILITERAL.NextNode());

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
        dbg.Location(89, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "getExpr");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Development\\TT.Net\\TT\\Template.g:91:1: setExpr : ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL ) ;
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET13 = null;
        IToken ID14 = null;
        IToken ASSIGN15 = null;
        IToken set16 = null;

        CommonTree SET13_tree=null;
        CommonTree ID14_tree=null;
        CommonTree ASSIGN15_tree=null;
        CommonTree set16_tree=null;

        try {
        	dbg.EnterRule(GrammarFileName, "setExpr");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(91, 1);

        try 
    	{
            // C:\\Development\\TT.Net\\TT\\Template.g:92:2: ( ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL ) )
            dbg.EnterAlt(1);

            // C:\\Development\\TT.Net\\TT\\Template.g:92:4: ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	dbg.Location(92,4);
            	// C:\\Development\\TT.Net\\TT\\Template.g:92:4: ( SET )?
            	int alt7 = 2;
            	try { dbg.EnterSubRule(7);
            	try { dbg.EnterDecision(7);

            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == SET) )
            	{
            	    alt7 = 1;
            	}
            	} finally { dbg.ExitDecision(7); }

            	switch (alt7) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);

            	        // C:\\Development\\TT.Net\\TT\\Template.g:92:4: SET
            	        {
            	        	dbg.Location(92,4);
            	        	SET13=(IToken)Match(input,SET,FOLLOW_SET_in_setExpr573); 
            	        		SET13_tree = (CommonTree)adaptor.Create(SET13);
            	        		adaptor.AddChild(root_0, SET13_tree);


            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(7); }

            	dbg.Location(92,9);
            	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr576); 
            		ID14_tree = (CommonTree)adaptor.Create(ID14);
            		adaptor.AddChild(root_0, ID14_tree);

            	dbg.Location(92,12);
            	ASSIGN15=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr578); 
            		ASSIGN15_tree = (CommonTree)adaptor.Create(ASSIGN15);
            		adaptor.AddChild(root_0, ASSIGN15_tree);

            	dbg.Location(92,19);
            	set16 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ILITERAL && input.LA(1) <= LITERAL) || input.LA(1) == ID || (input.LA(1) >= NUMBER && input.LA(1) <= DECIMAL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set16));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    dbg.RecognitionException(mse);
            	    throw mse;
            	}


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
        dbg.Location(93, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "setExpr");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "setExpr"

    // Delegated rules


	private void InitializeCyclicDFAs(IDebugEventListener dbg)
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_document479 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_TSTART_in_block491 = new BitSet(new ulong[]{0x0000080000001C10UL});
    public static readonly BitSet FOLLOW_statement_in_block494 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GET_in_getExpr525 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GET_in_getExpr539 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GET_in_getExpr553 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_in_setExpr573 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr576 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr578 = new BitSet(new ulong[]{0x0000680000000C00UL});
    public static readonly BitSet FOLLOW_set_in_setExpr580 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}