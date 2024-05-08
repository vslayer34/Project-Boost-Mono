using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBoostMono.Scripts.Helper;
/// <summary>
/// Contains references to the input map action names
/// </summary>
class InputActionNames
{
    /// <summary>
    /// Contains reference to user defined input actions
    /// </summary>
    public class User
    {
        /// <summary>
        /// Reference to the<c>"boost"</>input action
        /// </summary>
        public const string BOOST = "boost";

        /// <summary>
        /// Reference to the<c>"rotate_left"</>input action
        /// </summary>
        public const string ROTATE_LEFT = "rotate_left";

        /// <summary>
        /// Reference to the<c>"rotate_right"</>input action
        /// </summary>
        public const string ROTATE_RIGHT = "rotate_right";
    }

    /// <summary>
    /// Contains references to the built-in input actions
    /// </summary>
    public class BuiltIn
    {
        /// <summary>
        /// References to<c>"ui_accept"</c>action name
        /// </summary>
        public const string UI_ACCEPT = "ui_accept";

        /// <summary>
        /// References to<c>"ui_select"</c>action name
        /// </summary>
        public const string UI_SELECT = "ui_select";

        /// <summary>
        /// References to<c>"ui_cancel"</c>action name
        /// </summary>
        public const string UI_CANCEL = "ui_cancel";

        /// <summary>
        /// References to<c>"ui_focus_next"</c>action name
        /// </summary>
        public const string UI_FOCUS_NEXT = "ui_focus_next";

        /// <summary>
        /// References to<c>"ui_focus_prev"</c>action name
        /// </summary>
        public const string UI_FOCUS_PREV = "ui_focus_prev";

        /// <summary>
        /// References to<c>"ui_left"</c>action name
        /// </summary>
        public const string UI_LEFT = "ui_left";

        /// <summary>
        /// References to<c>"ui_right"</c>action name
        /// </summary>
        public const string UI_RIGHT = "ui_right";

        /// <summary>
        /// References to<c>"ui_up"</c>action name
        /// </summary>
        public const string UI_UP = "ui_up";

        /// <summary>
        /// References to<c>"ui_down"</c>action name
        /// </summary>
        public const string UI_DOWN = "ui_down";

        /// <summary>
        /// References to<c>"ui_page_up"</c>action name
        /// </summary>
        public const string UI_PAGE_UP = "ui_page_up";

        /// <summary>
        /// References to<c>"ui_page_down"</c>action name
        /// </summary>
        public const string UI_PAGE_DOWN = "ui_page_down";

        /// <summary>
        /// References to<c>"ui_home"</c>action name
        /// </summary>
        public const string UI_HOME = "ui_home";

        /// <summary>
        /// References to<c>"ui_end"</c>action name
        /// </summary>
        public const string UI_END = "ui_end";

        /// <summary>
        /// References to<c>"ui_cut"</c>action name
        /// </summary>
        public const string UI_CUT = "ui_cut";

        /// <summary>
        /// References to<c>"ui_copy"</c>action name
        /// </summary>
        public const string UI_COPY = "ui_copy";

        /// <summary>
        /// References to<c>"ui_paste"</c>action name
        /// </summary>
        public const string UI_PASTE = "ui_paste";

        /// <summary>
        /// References to<c>"ui_undo"</c>action name
        /// </summary>
        public const string UI_UNDO = "ui_undo";

        /// <summary>
        /// References to<c>"ui_redo"</c>action name
        /// </summary>
        public const string UI_REDO = "ui_redo";

        /// <summary>
        /// References to<c>"ui_text_completion_query"</c>action name
        /// </summary>
        public const string UI_TEXT_COMPLETION_QUERY = "ui_text_completion_query";

        /// <summary>
        /// References to<c>"ui_text_completion_accept"</c>action name
        /// </summary>
        public const string UI_TEXT_COMPLETION_ACCEPT = "ui_text_completion_accept";

        /// <summary>
        /// References to<c>"ui_text_completion_replace"</c>action name
        /// </summary>
        public const string UI_TEXT_COMPLETION_REPLACE = "ui_text_completion_replace";

        /// <summary>
        /// References to<c>"ui_text_newline"</c>action name
        /// </summary>
        public const string UI_TEXT_NEWLINE = "ui_text_newline";

        /// <summary>
        /// References to<c>"ui_text_newline_blank"</c>action name
        /// </summary>
        public const string UI_TEXT_NEWLINE_BLANK = "ui_text_newline_blank";

        /// <summary>
        /// References to<c>"ui_text_newline_above"</c>action name
        /// </summary>
        public const string UI_TEXT_NEWLINE_ABOVE = "ui_text_newline_above";

        /// <summary>
        /// References to<c>"ui_text_indent"</c>action name
        /// </summary>
        public const string UI_TEXT_INDENT = "ui_text_indent";

        /// <summary>
        /// References to<c>"ui_text_dedent"</c>action name
        /// </summary>
        public const string UI_TEXT_DEDENT = "ui_text_dedent";

        /// <summary>
        /// References to<c>"ui_text_backspace"</c>action name
        /// </summary>
        public const string UI_TEXT_BACKSPACE = "ui_text_backspace";

        /// <summary>
        /// References to<c>"ui_text_backspace_word"</c>action name
        /// </summary>
        public const string UI_TEXT_BACKSPACE_WORD = "ui_text_backspace_word";

        /// <summary>
        /// References to<c>"ui_text_backspace_word.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_BACKSPACE_WORD_MACOS = "ui_text_backspace_word.macos";

        /// <summary>
        /// References to<c>"ui_text_backspace_all_to_left"</c>action name
        /// </summary>
        public const string UI_TEXT_BACKSPACE_ALL_TO_LEFT = "ui_text_backspace_all_to_left";

        /// <summary>
        /// References to<c>"ui_text_backspace_all_to_left.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_BACKSPACE_ALL_TO_LEFT_MACOS = "ui_text_backspace_all_to_left.macos";

        /// <summary>
        /// References to<c>"ui_text_delete"</c>action name
        /// </summary>
        public const string UI_TEXT_DELETE = "ui_text_delete";

        /// <summary>
        /// References to<c>"ui_text_delete_word"</c>action name
        /// </summary>
        public const string UI_TEXT_DELETE_WORD = "ui_text_delete_word";

        /// <summary>
        /// References to<c>"ui_text_delete_word.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_DELETE_WORD_MACOS = "ui_text_delete_word.macos";

        /// <summary>
        /// References to<c>"ui_text_delete_all_to_right"</c>action name
        /// </summary>
        public const string UI_TEXT_DELETE_ALL_TO_RIGHT = "ui_text_delete_all_to_right";

        /// <summary>
        /// References to<c>"ui_text_delete_all_to_right.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_DELETE_ALL_TO_RIGHT_MACOS = "ui_text_delete_all_to_right.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_left"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_LEFT = "ui_text_caret_left";

        /// <summary>
        /// References to<c>"ui_text_caret_word_left"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_WORD_LEFT = "ui_text_caret_word_left";

        /// <summary>
        /// References to<c>"ui_text_caret_word_left.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_WORD_LEFT_MACOS = "ui_text_caret_word_left.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_right"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_RIGHT = "ui_text_caret_right";

        /// <summary>
        /// References to<c>"ui_text_caret_word_right"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_WORD_RIGHT = "ui_text_caret_word_right";

        /// <summary>
        /// References to<c>"ui_text_caret_word_right.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_WORD_RIGHT_MACOS = "ui_text_caret_word_right.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_up"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_UP = "ui_text_caret_up";

        /// <summary>
        /// References to<c>"ui_text_caret_down"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_DOWN = "ui_text_caret_down";

        /// <summary>
        /// References to<c>"ui_text_caret_line_start"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_LINE_START = "ui_text_caret_line_start";

        /// <summary>
        /// References to<c>"ui_text_caret_line_start.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_LINE_START_MACOS = "ui_text_caret_line_start.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_line_end"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_LINE_END = "ui_text_caret_line_end";

        /// <summary>
        /// References to<c>"ui_text_caret_line_end.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_LINE_END_MACOS = "ui_text_caret_line_end.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_page_up"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_PAGE_UP = "ui_text_caret_page_up";

        /// <summary>
        /// References to<c>"ui_text_caret_page_down"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_PAGE_DOWN = "ui_text_caret_page_down";

        /// <summary>
        /// References to<c>"ui_text_caret_document_start"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_DOCUMENT_START = "ui_text_caret_document_start";

        /// <summary>
        /// References to<c>"ui_text_caret_document_start.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_DOCUMENT_START_MACOS = "ui_text_caret_document_start.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_document_end"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_DOCUMENT_END = "ui_text_caret_document_end";

        /// <summary>
        /// References to<c>"ui_text_caret_document_end.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_DOCUMENT_END_MACOS = "ui_text_caret_document_end.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_add_below"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_ADD_BELOW = "ui_text_caret_add_below";

        /// <summary>
        /// References to<c>"ui_text_caret_add_below.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_ADD_BELOW_MACOS = "ui_text_caret_add_below.macos";

        /// <summary>
        /// References to<c>"ui_text_caret_add_above"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_ADD_ABOVE = "ui_text_caret_add_above";

        /// <summary>
        /// References to<c>"ui_text_caret_add_above.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_CARET_ADD_ABOVE_MACOS = "ui_text_caret_add_above.macos";

        /// <summary>
        /// References to<c>"ui_text_scroll_up"</c>action name
        /// </summary>
        public const string UI_TEXT_SCROLL_UP = "ui_text_scroll_up";

        /// <summary>
        /// References to<c>"ui_text_scroll_up.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_SCROLL_UP_MACOS = "ui_text_scroll_up.macos";

        /// <summary>
        /// References to<c>"ui_text_scroll_down"</c>action name
        /// </summary>
        public const string UI_TEXT_SCROLL_DOWN = "ui_text_scroll_down";

        /// <summary>
        /// References to<c>"ui_text_scroll_down.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_SCROLL_DOWN_MACOS = "ui_text_scroll_down.macos";

        /// <summary>
        /// References to<c>"ui_text_select_all"</c>action name
        /// </summary>
        public const string UI_TEXT_SELECT_ALL = "ui_text_select_all";

        /// <summary>
        /// References to<c>"ui_text_select_word_under_caret"</c>action name
        /// </summary>
        public const string UI_TEXT_SELECT_WORD_UNDER_CARET = "ui_text_select_word_under_caret";

        /// <summary>
        /// References to<c>"ui_text_select_word_under_caret.macos"</c>action name
        /// </summary>
        public const string UI_TEXT_SELECT_WORD_UNDER_CARET_MACOS = "ui_text_select_word_under_caret.macos";

        /// <summary>
        /// References to<c>"ui_text_add_selection_for_next_occurrence"</c>action name
        /// </summary>
        public const string UI_TEXT_ADD_SELECTION_FOR_NEXT_OCCURRENCE = "ui_text_add_selection_for_next_occurrence";

        /// <summary>
        /// References to<c>"ui_text_clear_carets_and_selection"</c>action name
        /// </summary>
        public const string UI_TEXT_CLEAR_CARETS_AND_SELECTION = "ui_text_clear_carets_and_selection";

        /// <summary>
        /// References to<c>"ui_text_toggle_insert_mode"</c>action name
        /// </summary>
        public const string UI_TEXT_TOGGLE_INSERT_MODE = "ui_text_toggle_insert_mode";

        /// <summary>
        /// References to<c>"ui_menu"</c>action name
        /// </summary>
        public const string UI_MENU = "ui_menu";

        /// <summary>
        /// References to<c>"ui_text_submit"</c>action name
        /// </summary>
        public const string UI_TEXT_SUBMIT = "ui_text_submit";

        /// <summary>
        /// References to<c>"ui_graph_duplicate"</c>action name
        /// </summary>
        public const string UI_GRAPH_DUPLICATE = "ui_graph_duplicate";

        /// <summary>
        /// References to<c>"ui_graph_delete"</c>action name
        /// </summary>
        public const string UI_GRAPH_DELETE = "ui_graph_delete";

        /// <summary>
        /// References to<c>"ui_filedialog_up_one_level"</c>action name
        /// </summary>
        public const string UI_FILEDIALOG_UP_ONE_LEVEL = "ui_filedialog_up_one_level";

        /// <summary>
        /// References to<c>"ui_filedialog_refresh"</c>action name
        /// </summary>
        public const string UI_FILEDIALOG_REFRESH = "ui_filedialog_refresh";

        /// <summary>
        /// References to<c>"ui_filedialog_show_hidden"</c>action name
        /// </summary>
        public const string UI_FILEDIALOG_SHOW_HIDDEN = "ui_filedialog_show_hidden";

        /// <summary>
        /// References to<c>"ui_swap_input_direction"</c>action name
        /// </summary>
        public const string UI_SWAP_INPUT_DIRECTION = "ui_swap_input_direction";
    }
}