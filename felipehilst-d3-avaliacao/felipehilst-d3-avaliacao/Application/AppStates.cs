namespace felipehilst_d3_avaliacao.Application
{
    public enum AppStates
    {
        START,
        AWAIT_ACCESS,
        AWAIT_CREDENTIALS,
        VALIDATE_CREDENTIALS,
        PROCESS_ACCESS,
        AWAIT_ACTION,
        PROCESS_UNLOG,
        DISMISS
    }
}

