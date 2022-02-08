# README
電chGameDevProject ActionShooter
## 現在のバージョン
version: 0.0.4
## 利用するUnityのバージョン
version: 2020.3.24f1 LTS
## Unityプロジェクトのフォルダ階層と管理について
### フォルダ階層
- Asset
    - Client 
        - Animations
        - Fonts
        - Materials
        - Prehabs
        - Scenes: 複数人での同時編集は禁止でお願いします。
            - フォルダ
                - Private: 進捗・プロトタイプ共有用のシーン(ビルドに含めない)
                    - InventorySystem
                        - 各個人のフォルダ(フォルダ名はフルネーム。ex) ShoSano)
                    - Player
                    - Enemy
                    - Stage
                    - ScenarioManagement
                    - TextSystem
                    - NPC
                    - UI
                        - HUD
                        - Frontend
            - シーン
                - (シーン名):(メイン編集者)
                - Title:下岡
                - Base:佐野
                - Stage01:山根
                - StageE01:山根
        - Scripts
            - Library: ゲーム内の要素以外
                - DesignPattern: デザインパターンの実装
                    - Singleton
                    - StateMachine
                - Editor: エディター関連
            - Projects: ゲーム内の要素
                - InventorySystem
                - Player
                - Enemy
                - Stage
                - ScenarioManagement
                - TextSystem
                - NPC
                - UI
                    - HUD
                    - Frontend
        - Sounds
        - Textures
    - 外部アセット01
    - 外部アセット02
    - 外部アセット...
    - MyResouces
        - 自分の作業を行う前のテスト用のリソースをおくフォルダ
        - テストが必要ない場合は、これを作成する必要はありません
        - この名前で作成されたフォルダは、バージョン管理対象外に設定しておきます。

### フォルダ管理
- ActionShooter班が作成したリソースは、テスト用のものを除いて全てをCLlientフォルダ以下に存在する形とします。
    - Client以下内でファイルをまとめる必要があると感じた場合は、フォルダを自由に追加して大丈夫です。
- 外部AssetはClientフォルダ外部に置き、外部アセットをまとめるフォルダは作りません。
- MyResoucesは各個人で必要があれば作成して下さい。バージョン管理対象外のため、gitからプルをしてもこのフォルダは存在しません。  
- ActionShooterの作業を行う際には、3種類の作業プロセスがあります！行う作業によって使い分けることを想定しています！
    1. Clientフォルダ以下にリソース(スクリプト、画像、音声など)を作成する。
        - 最も標準な作業プロセス
        - これから開発成果として、コミットやプッシュを行うつもりのリソースを作成・改良していく。
    2. Privateフォルダ以下にシーンを作成する。
        - 班内での進捗・プロトタイプ共有のための作業プロセス
    3. MyResoucesフォルダにテスト用のリソースを作成する。
        - 自分がイメージしている機能等が作成できるかを確認するためのプロセス
        - テスト用に作成したリソースがClientフォルダに紛れ込まないように明示しているため、しなければいけない作業ではない。

## GitとGitHubの運用について
<font color="Salmon">**今回はブランチの運用方法をGit-flowそのままとし、ブランチモデルに変更を全く加えない形での運用にします。** <br>
プルリクエストの利用も行いません。
</font>

- Gitのブランチモデルには、Git-Flowを利用します。
    - SourceTree内にGit-Flowを利用しやすくなる仕組みが存在しているため
    - Git-Flowの概念、全体的な流れについては、[Attlasian:GitFlowワークフロー](https://www.atlassian.com/ja/git/tutorials/comparing-workflows/gitflow-workflow)を参照してください。(この記事の中でMainと書かれている部分はmasterと同義です。)
    - SourceTreeでGit-Flowを利用する際には、リポジトリ画面右上のGit-Flowを押すことで機能を利用することができます

- GitとGitHubを用いた大まかな作業の流れ
    1. SourceTreeを開く。
    1. 自身の行う作業を確認する。
    1. origin/developブランチから、developブランチにプルを行う。
    1. developブランチからfeatureブランチを切って作業を行う。
        - featureブランチ名は”feature/[コンテンツ名]/[自分のフルネーム(ex:YamadaTaro)]”にしてください。
    1. 作業の節目でコミットを行うようにする。
        - 複数の機能を追加する際には、こまめにコミットをしておくとやり直しをすることもできます。
        - コミットメッセージには、自身の行った変更内容について箇条書きで書いてください。できる限り簡潔に。
        - コミットメッセージは1行目に大まかな作業内容を書くようにしてください。
            - 追加 -> Add:
            - 削除 -> Delete:
            - 更新 -> Update:     
            - 変更 -> Change:     など
    1. 自分の作業が終われば、作業を行った”feature/[コンテンツ名]/[自分のフルネーム]”ブランチをdevelopブランチにマージする。
    1. developブランチをorigin/developブランチにプッシュする。

- commit, pushを行う対象となるディレクトリ・ファイル
    - Client以下のディレクトリ・ファイル
    - 新たに必要なアセット




