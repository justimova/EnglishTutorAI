using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicsToGrammarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "07c2a460-4b62-4714-85f3-f244159dfa61");

            migrationBuilder.InsertData(
                table: "GrammarTopics",
                columns: new[] { "GrammarTopicId", "Description", "Explanation", "LanguageLevelId", "Order", "Text" },
                values: new object[,]
                {
                    { 16, "", "", 1, 1, "Alphabet and Pronunciation" },
                    { 17, "Subject-Verb-Object", "", 1, 2, "Basic Sentence Structure" },
                    { 18, "Present Simple", "", 1, 3, "To Be" },
                    { 19, "a, an, the", "", 1, 4, "Articles" },
                    { 20, "I, you, he, she, it, we, they", "", 1, 5, "Personal Pronouns" },
                    { 21, "my, your, his, her, its, our, their", "", 1, 6, "Possessive Adjectives" },
                    { 22, "Affirmative, Negative, Questions", "", 1, 7, "Simple Present Tense" },
                    { 23, "", "", 1, 8, "Common Adjectives" },
                    { 24, "", "", 1, 9, "Imperatives" },
                    { 25, "Regular and Irregular", "", 1, 10, "Plurals" },
                    { 26, "", "", 1, 11, "There is / There are" },
                    { 27, "in, on, under, next to, etc.", "", 1, 12, "Prepositions of Place" },
                    { 28, "", "", 1, 13, "Possessive 's" },
                    { 29, "", "", 1, 14, "Can for Ability" },
                    { 30, "Affirmative, Negative, Questions", "", 1, 15, "Present Continuous Tense" },
                    { 31, "who, what, where, when, why, how", "", 1, 16, "Question Words" },
                    { 32, "always, usually, sometimes, never", "", 1, 17, "Basic Adverbs of Frequency" },
                    { 33, "and, but, or", "", 1, 18, "Basic Conjunctions" },
                    { 34, "this, that, these, those", "", 1, 19, "Demonstratives" },
                    { 35, "", "", 1, 20, "Modal Verb 'Would like' for Polite Requests" },
                    { 36, "", "", 3, 1, "Present Perfect Tense" },
                    { 37, "", "", 3, 2, "Present Perfect Continuous Tense" },
                    { 38, "", "", 3, 3, "Past Perfect Tense" },
                    { 39, "", "", 3, 4, "Past Perfect Continuous Tense" },
                    { 40, "", "", 3, 5, "Future Continuous Tense" },
                    { 41, "", "", 3, 6, "Future Perfect Tense" },
                    { 42, "", "", 3, 7, "Future Perfect Continuous Tense" },
                    { 43, "", "", 3, 8, "Conditionals (First, Second, Third)" },
                    { 44, "Express wishes and regrets.", "", 3, 9, "Wish/If only" },
                    { 45, "", "", 3, 10, "Reported Speech" },
                    { 46, "", "", 3, 11, "Relative Clauses" },
                    { 47, "", "", 3, 12, "Passive Voice" },
                    { 48, "", "", 3, 13, "Gerunds and Infinitives" },
                    { 49, "", "", 3, 14, "Modals of Deduction and Speculation" },
                    { 50, "", "", 3, 15, "Modals of Obligation and Necessity" },
                    { 51, "", "", 3, 16, "Phrasal Verbs" },
                    { 52, "much, many, a lot of, few, little", "", 3, 17, "Quantifiers" },
                    { 53, "", "", 3, 18, "Adjectives and Adverbs" },
                    { 54, "", "", 3, 19, "Comparatives and Superlatives" },
                    { 55, "although, despite, in spite of", "", 3, 20, "Linking Words" },
                    { 56, "A comprehensive review of all tenses.", "", 4, 1, "Advanced Tenses Review" },
                    { 57, "Zero, First, Second, Third, Mixed", "", 4, 2, "Conditionals" },
                    { 58, "Advanced", "", 4, 3, "Passive Voice" },
                    { 59, "", "", 4, 4, "Causative Form" },
                    { 60, "Advanced", "", 4, 5, "Reported Speech" },
                    { 61, "Advanced", "", 4, 6, "Relative Clauses" },
                    { 62, "", "", 4, 7, "Modals of Probability and Speculation" },
                    { 63, "", "", 4, 8, "Modals of Advice and Suggestions" },
                    { 64, "", "", 4, 9, "Inversion for Emphasis" },
                    { 65, "", "", 4, 10, "Future Perfect and Future Continuous" },
                    { 66, "Advanced", "", 4, 11, "Gerunds and Infinitives" },
                    { 67, "Advanced", "", 4, 12, "Phrasal Verbs" },
                    { 68, "", "", 4, 13, "Hypothetical Situations" },
                    { 69, "", "", 4, 14, "Mixed Conditionals" },
                    { 70, "Advanced. Expressing wishes and regrets in complex sentences", "", 4, 15, "Wish/If only" },
                    { 71, "Various idiomatic", "", 4, 16, "Expressions with Get" },
                    { 72, "", "", 4, 17, "Collocations and Fixed Expressions" },
                    { 73, "Advanced", "", 4, 18, "Comparatives and Superlatives" },
                    { 74, "Turning verbs and adjectives into nouns", "", 4, 19, "Nominalization" },
                    { 75, "Words and phrases for organizing spoken and written language", "", 4, 20, "Discourse Markers" },
                    { 76, "The nuances of different tenses", "", 5, 1, "Advanced Tense Usage" },
                    { 77, "", "", 5, 2, "Subjunctive Mood" },
                    { 78, "Complex forms of passive voice", "", 5, 3, "Advanced Passive Structures" },
                    { 79, "Using past tenses for storytelling", "", 5, 4, "Narrative Tenses" },
                    { 80, "", "", 5, 5, "Cleft Sentences" },
                    { 81, "Complex relative clauses for adding detailed information.", "", 5, 6, "Relative Clauses" },
                    { 82, "Advanced", "", 5, 7, "Conditionals" },
                    { 83, "Advanced", "", 5, 8, "Inversion for Emphasis" },
                    { 84, "", "", 5, 9, "Ellipsis and Substitution" },
                    { 85, "Reporting complex statements, questions, and commands.", "", 5, 10, "Reported Speech" },
                    { 86, "Modals for past deductions, regrets, and speculation.", "", 5, 11, "Modals in Past Forms" },
                    { 87, "", "", 5, 12, "Complex Sentence Structures" },
                    { 88, "", "", 5, 13, "Advanced Phrasal Verbs and Idioms" },
                    { 89, "", "", 5, 14, "Hedging Language" },
                    { 90, "Advanced", "", 5, 15, "Nominalization" },
                    { 91, "", "", 5, 16, "Parallel Structures" },
                    { 92, "Advanced", "", 5, 17, "Discourse Markers" },
                    { 93, "", "", 5, 18, "Relative Pronouns and Adverbs" },
                    { 94, "", "", 5, 19, "Degrees of Certainty" },
                    { 95, "", "", 5, 20, "Complex Quantifiers" },
                    { 96, "Advanced", "", 6, 1, "Subjunctive Mood" },
                    { 97, "", "", 6, 2, "Advanced Conditional Structures" },
                    { 98, "", "", 6, 3, "Inversion in Conditional Sentences" },
                    { 99, "", "", 6, 4, "Advanced Passive Constructions" },
                    { 100, "Advanced", "", 6, 5, "Ellipsis and Substitution" },
                    { 101, "Advanced", "", 6, 6, "Cleft Sentences" },
                    { 102, "", "", 6, 7, "Nominalization in Formal Writing" },
                    { 103, "Expert Level", "", 6, 8, "Discourse Markers" },
                    { 104, "", "", 6, 9, "Advanced Modals" },
                    { 105, "", "", 6, 10, "Hedging in Academic Writing" },
                    { 106, "", "", 6, 11, "Complex Phrasal Verbs" },
                    { 107, "", "", 6, 12, "Idiomatic Expressions and Collocations" },
                    { 108, "", "", 6, 13, "Parallelism in Writing" },
                    { 109, "", "", 6, 14, "Advanced Relative Clauses" },
                    { 110, "", "", 6, 15, "Degrees of Formality" },
                    { 111, "Expert Level", "", 6, 16, "Complex Sentence Structures" },
                    { 112, "", "", 6, 17, "Advanced Reporting Verbs" },
                    { 113, "", "", 6, 18, "Expressing Nuance and Subtlety" },
                    { 114, "", "", 6, 19, "Advanced Syntax and Structure" },
                    { 115, "", "", 6, 20, "Exploring Regional Variations" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0834aa8-cbe7-4dfc-ae25-acfea0bf017f", 0, "50a8fe6b-ab4e-47cb-a9cf-15874477c99a", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "308245ef-d8c7-401e-b86f-3e882a6e7343", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b0834aa8-cbe7-4dfc-ae25-acfea0bf017f");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "07c2a460-4b62-4714-85f3-f244159dfa61", 0, "dd86d163-8a9d-45aa-a81e-edf57cc8057c", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "8d484c37-4abc-444a-8356-d31500dc1c11", false, "SuperAdmin" });
        }
    }
}
