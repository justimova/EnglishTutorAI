using DbModels;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interfaces;

namespace UnitOfWork;

public class ApplicationContext : DbContext, IUnitOfWork, IApplicationContext
{
	public DbSet<User> Users { get; set; } = null!;
	public DbSet<Essay> Essays { get; set; } = null!;
	public DbSet<AiMessage> AiMessages { get; set; } = null!;
	public DbSet<Story> Stories { get; set; } = null!;
	public DbSet<Author> Authors { get; set; } = null!;
	public DbSet<StoryParagraph> StoryParagraphs { get; set; } = null!;
	public DbSet<Dictionary> Dictionaries { get; set; } = null!;
	public DbSet<LanguageLevel> LanguageLevels { get; set; } = null!;
	public DbSet<GrammarTopic> GrammarTopics { get; set; } = null!;

	public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options) {
		//Database.EnsureDeleted();
		//Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<User>().HasData(
			new User { UserName = "SuperAdmin", Email = "SuperAdmin@gmail.com" }
		);
		modelBuilder.Entity<LanguageLevel>().HasData(
			new LanguageLevel { LanguageLevelId = 1, Code = "A1", Name = "Beginner", Order = 1, Description = "Can understand and use familiar everyday expressions and very basic phrases aimed at the satisfaction of needs of a concrete type.\r\nCan introduce themselves and others and can ask and answer questions about personal details such as where they live, people they know, and things they have.\r\nCan interact in a simple way provided the other person talks slowly and clearly and is prepared to help." },
			new LanguageLevel { LanguageLevelId = 2, Code = "A2", Name = "Elementary", Order = 2, Description = "Can understand sentences and frequently used expressions related to areas of most immediate relevance (e.g., very basic personal and family information, shopping, local geography, employment).\r\nCan communicate in simple and routine tasks requiring a simple and direct exchange of information on familiar and routine matters.\r\nCan describe in simple terms aspects of their background, immediate environment, and matters in areas of immediate need." },
			new LanguageLevel { LanguageLevelId = 3, Code = "B1", Name = "Intermediate", Order = 3, Description = "Can understand the main points of clear standard input on familiar matters regularly encountered in work, school, leisure, etc.\r\nCan deal with most situations likely to arise while traveling in an area where the language is spoken.\r\nCan produce simple connected text on topics that are familiar or of personal interest.\r\nCan describe experiences and events, dreams, hopes, and ambitions and briefly give reasons and explanations for opinions and plans." },
			new LanguageLevel { LanguageLevelId = 4, Code = "B2", Name = "Upper Intermediate", Order = 4, Description = "Can understand the main ideas of complex text on both concrete and abstract topics, including technical discussions in their field of specialization.\r\nCan interact with a degree of fluency and spontaneity that makes regular interaction with native speakers quite possible without strain for either party.\r\nCan produce clear, detailed text on a wide range of subjects and explain a viewpoint on a topical issue giving the advantages and disadvantages of various options." },
			new LanguageLevel { LanguageLevelId = 5, Code = "C1", Name = "Advanced", Order = 5, Description = "Can understand a wide range of demanding, longer texts, and recognize implicit meaning.\r\nCan express ideas fluently and spontaneously without much obvious searching for expressions.\r\nCan use language flexibly and effectively for social, academic, and professional purposes.\r\nCan produce clear, well-structured, detailed text on complex subjects, showing controlled use of organizational patterns, connectors, and cohesive devices." },
			new LanguageLevel { LanguageLevelId = 6, Code = "C2", Name = "Proficiency", Order = 6, Description = "Can understand with ease virtually everything heard or read.\r\nCan summarize information from different spoken and written sources, reconstructing arguments and accounts in a coherent presentation.\r\nCan express themselves spontaneously, very fluently and precisely, differentiating finer shades of meaning even in more complex situations." }
		);
		modelBuilder.Entity<GrammarTopic>().HasData(
			new GrammarTopic { GrammarTopicId = 1, Text = "Present Simple Tense", Description = "For habitual actions and daily routines", LanguageLevelId = 2, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 2, Text = "Present Continuous Tense", Description = "For actions happening at the moment of speaking", LanguageLevelId = 2, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 3, Text = "Past Simple Tense", Description = "To talk about completed actions in the past", LanguageLevelId = 2, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 4, Text = "Future with 'going to'", Description = "For planned actions or intentions", LanguageLevelId = 2, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 5, Text = "Can/Could for Ability", Description = "To express ability or possibility", LanguageLevelId = 2, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 6, Text = "Comparatives and Superlatives", Description = "To compare things and people", LanguageLevelId = 2, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 7, Text = "Prepositions of Time", Description = "Such as 'in', 'at', 'on' for describing time", LanguageLevelId = 2, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 8, Text = "Prepositions of Place", Description = "Such as 'in', 'at', 'on' for describing location", LanguageLevelId = 2, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 9, Text = "Simple Modal Verbs", Description = "Such as 'must', 'should' for necessity and advice", LanguageLevelId = 2, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 10, Text = "Possessives", Description = "Using 's and s' to show possession", LanguageLevelId = 2, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 11, Text = "Countable and Uncountable Nouns", Description = "Including use of 'some' and 'any'", LanguageLevelId = 2, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 12, Text = "Adverbs of Frequency", Description = "Such as 'always', 'usually', 'often', 'sometimes', 'never'", LanguageLevelId = 2, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 13, Text = "There is/There are", Description = "To describe the existence or presence of something", LanguageLevelId = 2, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 14, Text = "Imperatives", Description = "For giving direct orders and requests", LanguageLevelId = 2, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 15, Text = "Past Continuous Tense", Description = "For actions that were in progress at a specific time in the past", LanguageLevelId = 2, Order = 15, Explanation = "" },

			new GrammarTopic { GrammarTopicId = 16, Text = "Alphabet and Pronunciation", Description = "", LanguageLevelId = 1, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 17, Text = "Basic Sentence Structure", Description = "Subject-Verb-Object", LanguageLevelId = 1, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 18, Text = "To Be", Description = "Present Simple", LanguageLevelId = 1, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 19, Text = "Articles", Description = "a, an, the", LanguageLevelId = 1, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 20, Text = "Personal Pronouns", Description = "I, you, he, she, it, we, they", LanguageLevelId = 1, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 21, Text = "Possessive Adjectives", Description = "my, your, his, her, its, our, their", LanguageLevelId = 1, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 22, Text = "Simple Present Tense", Description = "Affirmative, Negative, Questions", LanguageLevelId = 1, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 23, Text = "Common Adjectives", Description = "", LanguageLevelId = 1, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 24, Text = "Imperatives", Description = "", LanguageLevelId = 1, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 25, Text = "Plurals", Description = "Regular and Irregular", LanguageLevelId = 1, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 26, Text = "There is / There are", Description = "", LanguageLevelId = 1, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 27, Text = "Prepositions of Place", Description = "in, on, under, next to, etc.", LanguageLevelId = 1, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 28, Text = "Possessive 's", Description = "", LanguageLevelId = 1, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 29, Text = "Can for Ability", Description = "", LanguageLevelId = 1, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 30, Text = "Present Continuous Tense", Description = "Affirmative, Negative, Questions", LanguageLevelId = 1, Order = 15, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 31, Text = "Question Words", Description = "who, what, where, when, why, how", LanguageLevelId = 1, Order = 16, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 32, Text = "Basic Adverbs of Frequency", Description = "always, usually, sometimes, never", LanguageLevelId = 1, Order = 17, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 33, Text = "Basic Conjunctions", Description = "and, but, or", LanguageLevelId = 1, Order = 18, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 34, Text = "Demonstratives", Description = "this, that, these, those", LanguageLevelId = 1, Order = 19, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 35, Text = "Modal Verb 'Would like' for Polite Requests", Description = "", LanguageLevelId = 1, Order = 20, Explanation = "" },

			new GrammarTopic { GrammarTopicId = 36, Text = "Present Perfect Tense", Description = "", LanguageLevelId = 3, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 37, Text = "Present Perfect Continuous Tense", Description = "", LanguageLevelId = 3, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 38, Text = "Past Perfect Tense", Description = "", LanguageLevelId = 3, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 39, Text = "Past Perfect Continuous Tense", Description = "", LanguageLevelId = 3, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 40, Text = "Future Continuous Tense", Description = "", LanguageLevelId = 3, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 41, Text = "Future Perfect Tense", Description = "", LanguageLevelId = 3, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 42, Text = "Future Perfect Continuous Tense", Description = "", LanguageLevelId = 3, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 43, Text = "Conditionals (First, Second, Third)", Description = "", LanguageLevelId = 3, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 44, Text = "Wish/If only", Description = "Express wishes and regrets.", LanguageLevelId = 3, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 45, Text = "Reported Speech", Description = "", LanguageLevelId = 3, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 46, Text = "Relative Clauses", Description = "", LanguageLevelId = 3, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 47, Text = "Passive Voice", Description = "", LanguageLevelId = 3, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 48, Text = "Gerunds and Infinitives", Description = "", LanguageLevelId = 3, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 49, Text = "Modals of Deduction and Speculation", Description = "", LanguageLevelId = 3, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 50, Text = "Modals of Obligation and Necessity", Description = "", LanguageLevelId = 3, Order = 15, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 51, Text = "Phrasal Verbs", Description = "", LanguageLevelId = 3, Order = 16, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 52, Text = "Quantifiers", Description = "much, many, a lot of, few, little", LanguageLevelId = 3, Order = 17, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 53, Text = "Adjectives and Adverbs", Description = "", LanguageLevelId = 3, Order = 18, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 54, Text = "Comparatives and Superlatives", Description = "", LanguageLevelId = 3, Order = 19, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 55, Text = "Linking Words", Description = "although, despite, in spite of", LanguageLevelId = 3, Order = 20, Explanation = "" },

			new GrammarTopic { GrammarTopicId = 56, Text = "Advanced Tenses Review", Description = "A comprehensive review of all tenses.", LanguageLevelId = 4, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 57, Text = "Conditionals", Description = "Zero, First, Second, Third, Mixed", LanguageLevelId = 4, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 58, Text = "Passive Voice", Description = "Advanced", LanguageLevelId = 4, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 59, Text = "Causative Form", Description = "", LanguageLevelId = 4, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 60, Text = "Reported Speech", Description = "Advanced", LanguageLevelId = 4, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 61, Text = "Relative Clauses", Description = "Advanced", LanguageLevelId = 4, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 62, Text = "Modals of Probability and Speculation", Description = "", LanguageLevelId = 4, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 63, Text = "Modals of Advice and Suggestions", Description = "", LanguageLevelId = 4, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 64, Text = "Inversion for Emphasis", Description = "", LanguageLevelId = 4, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 65, Text = "Future Perfect and Future Continuous", Description = "", LanguageLevelId = 4, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 66, Text = "Gerunds and Infinitives", Description = "Advanced", LanguageLevelId = 4, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 67, Text = "Phrasal Verbs", Description = "Advanced", LanguageLevelId = 4, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 68, Text = "Hypothetical Situations", Description = "", LanguageLevelId = 4, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 69, Text = "Mixed Conditionals", Description = "", LanguageLevelId = 4, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 70, Text = "Wish/If only", Description = "Advanced. Expressing wishes and regrets in complex sentences", LanguageLevelId = 4, Order = 15, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 71, Text = "Expressions with Get", Description = "Various idiomatic", LanguageLevelId = 4, Order = 16, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 72, Text = "Collocations and Fixed Expressions", Description = "", LanguageLevelId = 4, Order = 17, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 73, Text = "Comparatives and Superlatives", Description = "Advanced", LanguageLevelId = 4, Order = 18, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 74, Text = "Nominalization", Description = "Turning verbs and adjectives into nouns", LanguageLevelId = 4, Order = 19, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 75, Text = "Discourse Markers", Description = "Words and phrases for organizing spoken and written language", LanguageLevelId = 4, Order = 20, Explanation = "" },

			new GrammarTopic { GrammarTopicId = 76, Text = "Advanced Tense Usage", Description = "The nuances of different tenses", LanguageLevelId = 5, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 77, Text = "Subjunctive Mood", Description = "", LanguageLevelId = 5, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 78, Text = "Advanced Passive Structures", Description = "Complex forms of passive voice", LanguageLevelId = 5, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 79, Text = "Narrative Tenses", Description = "Using past tenses for storytelling", LanguageLevelId = 5, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 80, Text = "Cleft Sentences", Description = "", LanguageLevelId = 5, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 81, Text = "Relative Clauses", Description = "Complex relative clauses for adding detailed information.", LanguageLevelId = 5, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 82, Text = "Conditionals", Description = "Advanced", LanguageLevelId = 5, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 83, Text = "Inversion for Emphasis", Description = "Advanced", LanguageLevelId = 5, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 84, Text = "Ellipsis and Substitution", Description = "", LanguageLevelId = 5, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 85, Text = "Reported Speech", Description = "Reporting complex statements, questions, and commands.", LanguageLevelId = 5, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 86, Text = "Modals in Past Forms", Description = "Modals for past deductions, regrets, and speculation.", LanguageLevelId = 5, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 87, Text = "Complex Sentence Structures", Description = "", LanguageLevelId = 5, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 88, Text = "Advanced Phrasal Verbs and Idioms", Description = "", LanguageLevelId = 5, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 89, Text = "Hedging Language", Description = "", LanguageLevelId = 5, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 90, Text = "Nominalization", Description = "Advanced", LanguageLevelId = 5, Order = 15, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 91, Text = "Parallel Structures", Description = "", LanguageLevelId = 5, Order = 16, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 92, Text = "Discourse Markers", Description = "Advanced", LanguageLevelId = 5, Order = 17, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 93, Text = "Relative Pronouns and Adverbs", Description = "", LanguageLevelId = 5, Order = 18, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 94, Text = "Degrees of Certainty", Description = "", LanguageLevelId = 5, Order = 19, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 95, Text = "Complex Quantifiers", Description = "", LanguageLevelId = 5, Order = 20, Explanation = "" },


			new GrammarTopic { GrammarTopicId = 96, Text = "Subjunctive Mood", Description = "Advanced", LanguageLevelId = 6, Order = 1, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 97, Text = "Advanced Conditional Structures", Description = "", LanguageLevelId = 6, Order = 2, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 98, Text = "Inversion in Conditional Sentences", Description = "", LanguageLevelId = 6, Order = 3, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 99, Text = "Advanced Passive Constructions", Description = "", LanguageLevelId = 6, Order = 4, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 100, Text = "Ellipsis and Substitution", Description = "Advanced", LanguageLevelId = 6, Order = 5, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 101, Text = "Cleft Sentences", Description = "Advanced", LanguageLevelId = 6, Order = 6, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 102, Text = "Nominalization in Formal Writing", Description = "", LanguageLevelId = 6, Order = 7, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 103, Text = "Discourse Markers", Description = "Expert Level", LanguageLevelId = 6, Order = 8, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 104, Text = "Advanced Modals", Description = "", LanguageLevelId = 6, Order = 9, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 105, Text = "Hedging in Academic Writing", Description = "", LanguageLevelId = 6, Order = 10, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 106, Text = "Complex Phrasal Verbs", Description = "", LanguageLevelId = 6, Order = 11, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 107, Text = "Idiomatic Expressions and Collocations", Description = "", LanguageLevelId = 6, Order = 12, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 108, Text = "Parallelism in Writing", Description = "", LanguageLevelId = 6, Order = 13, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 109, Text = "Advanced Relative Clauses", Description = "", LanguageLevelId = 6, Order = 14, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 110, Text = "Degrees of Formality", Description = "", LanguageLevelId = 6, Order = 15, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 111, Text = "Complex Sentence Structures", Description = "Expert Level", LanguageLevelId = 6, Order = 16, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 112, Text = "Advanced Reporting Verbs", Description = "", LanguageLevelId = 6, Order = 17, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 113, Text = "Expressing Nuance and Subtlety", Description = "", LanguageLevelId = 6, Order = 18, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 114, Text = "Advanced Syntax and Structure", Description = "", LanguageLevelId = 6, Order = 19, Explanation = "" },
			new GrammarTopic { GrammarTopicId = 115, Text = "Exploring Regional Variations", Description = "", LanguageLevelId = 6, Order = 20, Explanation = "" }
		);
		modelBuilder.Entity<Author>().HasData(
			new Author { AuthorId = 1, AuthorName = "Edgar Allan Poe" },
			new Author { AuthorId = 2, AuthorName = "O.Henry" },
			new Author { AuthorId = 3, AuthorName = "Ernest Hemingway" },
			new Author { AuthorId = 4, AuthorName = "F.Scott Fitzgerald" },
			new Author { AuthorId = 5, AuthorName = "Alice Munro" },
			new Author { AuthorId = 6, AuthorName = "Jorge Luis Borges" },
			new Author { AuthorId = 7, AuthorName = "Guy de Maupassant" },
			new Author { AuthorId = 8, AuthorName = "Ray Bradbury" },
			new Author { AuthorId = 9, AuthorName = "Flannery O'Connor" },
			new Author { AuthorId = 10, AuthorName = "Shirley Jackson" },
			new Author { AuthorId = 11, AuthorName = "Haruki Murakami" },
			new Author { AuthorId = 12, AuthorName = "Jules Verne" },
			new Author { AuthorId = 13, AuthorName = "Mark Twain" },
			new Author { AuthorId = 14, AuthorName = "Stephen King" },
			new Author { AuthorId = 15, AuthorName = "John Cheever" },
			new Author { AuthorId = 16, AuthorName = "Isaac Asimov" },
			new Author { AuthorId = 17, AuthorName = "James Joyce" },
			new Author { AuthorId = 18, AuthorName = "Nathaniel Hawthorne" },
			new Author { AuthorId = 19, AuthorName = "H.P.Lovecraft" },
			new Author { AuthorId = 20, AuthorName = "Virginia Woolf" },
			new Author { AuthorId = 21, AuthorName = "William Faulkner" },
			new Author { AuthorId = 22, AuthorName = "Eudora Welty" },
			new Author { AuthorId = 23, AuthorName = "Katherine Mansfield" },
			new Author { AuthorId = 24, AuthorName = "Kurt Vonnegut" },
			new Author { AuthorId = 25, AuthorName = "Philip K.Dick" },
			new Author { AuthorId = 26, AuthorName = "Charles Bukowski" },
			new Author { AuthorId = 27, AuthorName = "Roald Dahl" },
			new Author { AuthorId = 28, AuthorName = "Henry James" },
			new Author { AuthorId = 29, AuthorName = "Edgar Rice Burroughs" },
			new Author { AuthorId = 30, AuthorName = "Truman Capote" }
		);
	}

	void IUnitOfWork.SaveChanges() {
		SaveChanges();
	}

	async Task<int> IUnitOfWork.SaveChangesAsync() {
		return await SaveChangesAsync();
	}
}
