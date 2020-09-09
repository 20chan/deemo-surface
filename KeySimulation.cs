namespace Hook {
    public static class KeySimulation {
        public static void MakeKeyEvent(int vkCode, KeyboardEventType type) {
            switch (type) {
                case KeyboardEventType.KEYDOWN:
                    WinAPI.keybd_event((byte)vkCode, 0x00, 0x00, 0);
                    break;
                case KeyboardEventType.KEYUP:
                    WinAPI.keybd_event((byte)vkCode, 0x00, 0x02, 0);
                    break;
                case KeyboardEventType.KEYCLICK:
                    WinAPI.keybd_event((byte)vkCode, 0x00, 0x00, 0);
                    WinAPI.keybd_event((byte)vkCode, 0x00, 0x02, 0);
                    break;
            }
        }
    }

    public enum KeyboardEventType {
        KEYDOWN,
        KEYUP,
        KEYCLICK
    }
}