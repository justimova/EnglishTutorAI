using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWork.Migrations
{
    /// <inheritdoc />
    public partial class AddExplToGrammarTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0e8885c5-c688-4d7d-bf57-c484cf0a2446");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 1,
                column: "Explanation",
                value: "<div>\r\n    <h3>Present Simple Tense for Habitual Actions and Daily Routines</h3>\r\n    <p>The Present Simple tense is used to describe habitual actions and daily routines. At the A2 level, this is an essential grammar point as it helps learners talk about their everyday activities and routines.</p>\r\n    \r\n    <h4>Usage of Present Simple Tense</h4>\r\n    <ul>\r\n        <li><strong>Habitual Actions:</strong> Actions that happen regularly or are part of a routine.\r\n            <ul>\r\n                <li>Example: She <em>walks</em> to school every day.</li>\r\n                <li>Example: They <em>visit</em> their grandparents every Sunday.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>General Truths and Facts:</strong> Statements that are always true.\r\n            <ul>\r\n                <li>Example: The sun <em>rises</em> in the east.</li>\r\n                <li>Example: Water <em>boils</em> at 100 degrees Celsius.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Scheduled Events:</strong> Fixed events in the near future, especially in timetables.\r\n            <ul>\r\n                <li>Example: The train <em>leaves</em> at 9 PM.</li>\r\n                <li>Example: School <em>starts</em> next Monday.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Structure of Present Simple Tense</h4>\r\n    <ul>\r\n        <li><strong>Affirmative Sentences:</strong> Subject + base form of the verb (with -s or -es for he, she, it).\r\n            <ul>\r\n                <li>Example: I <em>play</em>, you <em>play</em>, he <em>plays</em>, we <em>play</em>, they <em>play</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Negative Sentences:</strong> Subject + do/does + not + base form of the verb.\r\n            <ul>\r\n                <li>Example: I <em>do not play</em>, he <em>does not play</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Questions:</strong> Do/Does + subject + base form of the verb?\r\n            <ul>\r\n                <li>Example: <em>Do</em> you <em>play</em>? <em>Does</em> she <em>play</em>?</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Key Points to Remember</h4>\r\n    <ul>\r\n        <li><strong>Third Person Singular:</strong> Add -s or -es to the base form of the verb.\r\n            <ul>\r\n                <li>Example: He <em>runs</em>, she <em>watches</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Adverbs of Frequency:</strong> Use adverbs like always, usually, often, sometimes, rarely, never to indicate how often something happens.\r\n            <ul>\r\n                <li>Example: She <em>always</em> drinks coffee in the morning.</li>\r\n                <li>Example: They <em>never</em> go out on Sundays.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Practice Examples</h4>\r\n    <ul>\r\n        <li><strong>Fill in the blanks:</strong> She ___ (go) to the gym every morning.</li>\r\n        <li><strong>Sentence construction:</strong> (my sister / always / read / before bed) - My sister always reads before bed.</li>\r\n        <li><strong>Daily routine description:</strong> Describe your typical day using the Present Simple.</li>\r\n        <li><strong>Questions and answers:</strong> What time do you usually wake up? - I usually wake up at 6 AM.</li>\r\n    </ul>\r\n    \r\n    <p>Understanding and using the Present Simple effectively will greatly improve your ability to discuss daily activities and routines in English.</p>\r\n</div>\r\n");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 2,
                column: "Explanation",
                value: "<div>\r\n    <h3>Present Continuous Tense for Actions Happening at the Moment of Speaking</h3>\r\n    <p>The Present Continuous tense is used to describe actions that are happening right now, at the moment of speaking. At the A2 level, this is an essential grammar point as it helps learners talk about current activities.</p>\r\n    \r\n    <h4>Usage of Present Continuous Tense</h4>\r\n    <ul>\r\n        <li><strong>Actions Happening Now:</strong> Describing what is happening at the exact moment of speaking.\r\n            <ul>\r\n                <li>Example: She <em>is reading</em> a book right now.</li>\r\n                <li>Example: They <em>are playing</em> football at the moment.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Temporary Actions:</strong> Actions that are happening around the present time but not necessarily at the exact moment of speaking.\r\n            <ul>\r\n                <li>Example: I <em>am staying</em> with my friends this week.</li>\r\n                <li>Example: He <em>is working</em> on a new project these days.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Future Arrangements:</strong> Planned future events.\r\n            <ul>\r\n                <li>Example: We <em>are meeting</em> John tomorrow.</li>\r\n                <li>Example: They <em>are traveling</em> to Paris next month.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Structure of Present Continuous Tense</h4>\r\n    <ul>\r\n        <li><strong>Affirmative Sentences:</strong> Subject + am/is/are + verb + -ing.\r\n            <ul>\r\n                <li>Example: I <em>am studying</em>, you <em>are studying</em>, he <em>is studying</em>, we <em>are studying</em>, they <em>are studying</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Negative Sentences:</strong> Subject + am/is/are + not + verb + -ing.\r\n            <ul>\r\n                <li>Example: I <em>am not studying</em>, he <em>is not studying</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Questions:</strong> Am/Is/Are + subject + verb + -ing?\r\n            <ul>\r\n                <li>Example: <em>Am</em> I <em>studying</em>? <em>Is</em> he <em>studying</em>? <em>Are</em> they <em>studying</em>?</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Key Points to Remember</h4>\r\n    <ul>\r\n        <li><strong>Forming the -ing form:</strong> For most verbs, add -ing to the base form. For verbs ending in -e, drop the -e and add -ing (e.g., make -> making). For one-syllable verbs ending in a consonant-vowel-consonant, double the final consonant (e.g., sit -> sitting).</li>\r\n        <li><strong>Common Time Expressions:</strong> Use time expressions such as now, right now, at the moment, these days, this week to indicate actions happening in the present.\r\n            <ul>\r\n                <li>Example: She is working <em>right now</em>.</li>\r\n                <li>Example: They are playing football <em>at the moment</em>.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Practice Examples</h4>\r\n    <ul>\r\n        <li><strong>Fill in the blanks:</strong> She ___ (read) a book right now.</li>\r\n        <li><strong>Sentence construction:</strong> (my friends / play / football / at the moment) - My friends are playing football at the moment.</li>\r\n        <li><strong>Describe the picture:</strong> Look at the picture and describe what the people are doing using the Present Continuous tense.</li>\r\n        <li><strong>Questions and answers:</strong> What are you doing right now? - I am studying English.</li>\r\n    </ul>\r\n    \r\n    <p>Understanding and using the Present Continuous effectively will greatly improve your ability to discuss current activities and temporary actions in English.</p>\r\n</div>\r\n");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 3,
                column: "Explanation",
                value: "<div>\r\n    <h3>Past Simple Tense to Talk About Completed Actions in the Past</h3>\r\n    <p>The Past Simple tense is used to describe actions that were completed at a specific time in the past. At the A2 level, understanding this tense is essential for talking about past experiences, events, and actions.</p>\r\n    \r\n    <h4>Usage of Past Simple Tense</h4>\r\n    <ul>\r\n        <li><strong>Completed Actions:</strong> Actions that started and finished at a specific time in the past.\r\n            <ul>\r\n                <li>Example: She <em>visited</em> her grandparents last weekend.</li>\r\n                <li>Example: They <em>watched</em> a movie yesterday.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Past Habits:</strong> Actions that happened regularly in the past but do not happen now.\r\n            <ul>\r\n                <li>Example: When I was a child, I <em>played</em> outside every day.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Past States:</strong> Situations or states that were true in the past.\r\n            <ul>\r\n                <li>Example: She <em>was</em> very shy when she was younger.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Structure of Past Simple Tense</h4>\r\n    <ul>\r\n        <li><strong>Affirmative Sentences:</strong> Subject + verb in the past form.\r\n            <ul>\r\n                <li>Example: I <em>visited</em>, you <em>visited</em>, he <em>visited</em>, we <em>visited</em>, they <em>visited</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Negative Sentences:</strong> Subject + did not (didn't) + base form of the verb.\r\n            <ul>\r\n                <li>Example: I <em>did not visit</em>, he <em>did not visit</em>.</li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Questions:</strong> Did + subject + base form of the verb?\r\n            <ul>\r\n                <li>Example: <em>Did</em> you <em>visit</em>? <em>Did</em> she <em>visit</em>?</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Forming the Past Simple</h4>\r\n    <p>For regular verbs, add -ed to the base form of the verb. For irregular verbs, use the second form of the verb (past simple form). Here are some examples:</p>\r\n    <ul>\r\n        <li><strong>Regular Verbs:</strong>\r\n            <ul>\r\n                <li>Example: walk -> <em>walked</em></li>\r\n                <li>Example: visit -> <em>visited</em></li>\r\n            </ul>\r\n        </li>\r\n        <li><strong>Irregular Verbs:</strong>\r\n            <ul>\r\n                <li>Example: go -> <em>went</em></li>\r\n                <li>Example: eat -> <em>ate</em></li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Key Points to Remember</h4>\r\n    <ul>\r\n        <li><strong>Time Expressions:</strong> Use specific time expressions to indicate when something happened, such as yesterday, last week, two days ago, in 1990.\r\n            <ul>\r\n                <li>Example: She visited Paris <em>last summer</em>.</li>\r\n                <li>Example: They moved to a new house <em>two years ago</em>.</li>\r\n            </ul>\r\n        </li>\r\n    </ul>\r\n    \r\n    <h4>Practice Examples</h4>\r\n    <ul>\r\n        <li><strong>Fill in the blanks:</strong> She ___ (visit) her grandparents last weekend.</li>\r\n        <li><strong>Sentence construction:</strong> (we / watch / a movie / yesterday) - We watched a movie yesterday.</li>\r\n        <li><strong>Write about your past:</strong> Describe a memorable event from your past using the Past Simple tense.</li>\r\n        <li><strong>Questions and answers:</strong> Did you travel last summer? - Yes, I traveled to Spain.</li>\r\n    </ul>\r\n    \r\n    <p>Understanding and using the Past Simple tense effectively will greatly improve your ability to discuss past events and share your experiences in English.</p>\r\n</div>\r\n");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1a27d522-175a-4bf8-a084-ea099005f2ef", 0, "1f21601e-9c3a-4926-bcb1-041df29431ed", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "e0784b17-3043-42bd-a5c3-11399b1a1dec", false, "SuperAdmin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1a27d522-175a-4bf8-a084-ea099005f2ef");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 1,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 2,
                column: "Explanation",
                value: "");

            migrationBuilder.UpdateData(
                table: "GrammarTopics",
                keyColumn: "GrammarTopicId",
                keyValue: 3,
                column: "Explanation",
                value: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e8885c5-c688-4d7d-bf57-c484cf0a2446", 0, "4bf845a1-2dc9-497b-96e8-25b4a4926ad0", "SuperAdmin@gmail.com", false, null, null, false, null, null, null, null, null, false, "ffa5cbb0-d42a-4aeb-a5c5-444a491f4b67", false, "SuperAdmin" });
        }
    }
}
